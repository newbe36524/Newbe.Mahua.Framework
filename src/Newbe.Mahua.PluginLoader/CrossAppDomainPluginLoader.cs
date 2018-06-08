using Autofac;
using Autofac.Features.Variance;
using MediatR;
using MessagePack;
using Newbe.Mahua.Apis;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Internals;
using Newbe.Mahua.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace Newbe.Mahua
{
    public class CrossAppDomainPluginLoader : MarshalByRefObject, IPluginLoader
    {
        public string Message { get; private set; }

        public override object InitializeLifetimeService()
        {
            var lease = (ILease)base.InitializeLifetimeService();
            System.Diagnostics.Debug.Assert(lease != null, "lease != null");
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(0);
            }
            return lease;
        }

        public bool LoadPlugin(string pluginEntryPointDllFullFilename)
        {
            Debug($"当前AppDomain:{AppDomain.CurrentDomain.FriendlyName}，开始加载插件程序集：{pluginEntryPointDllFullFilename}");
            try
            {
                Assembly.Load(new AssemblyName
                {
                    CodeBase = pluginEntryPointDllFullFilename,
                });
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    Debug($"当前已加载程序集:{assembly.FullName}");
                }
                Debug("程序集加载完毕,开始构建Container");
                var superBuilder = new ContainerBuilder();
                superBuilder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).AsImplementedInterfaces()
                    .AsSelf();
                var superContainer = superBuilder.Build();
                Debug("IMahuaModule扫描容器，构建完毕。开始扫描IMahuaModule。");
                var subBuilderRegisters = superContainer.Resolve<IMahuaModule[]>().ToArray();
                Debug($"共发现{subBuilderRegisters.Length}个IMahuaModule");
                var builder = new ContainerBuilder();
                foreach (var autofacContainerBuilder in subBuilderRegisters)
                {
                    var modules = autofacContainerBuilder.GetModules();
                    Debug($"{autofacContainerBuilder.GetType().FullName} 中发现了 {modules.Length} 个 Autofac.Module。");
                    foreach (var module in modules)
                    {
                        builder.RegisterModule(module);
                        Debug($"注册了 {module.GetType().FullName}");
                    }
                }
                Debug("IMahuaModule扫描注册完毕。");

                // enables contravariant Resolve() for interfaces with single contravariant ("in") arg
                builder
                    .RegisterSource(new ContravariantRegistrationSource());

                // mediator itself
                builder
                    .RegisterType<Mediator>()
                    .As<IMediator>()
                    .InstancePerLifetimeScope();

                // request handlers
                builder
                    .Register<SingleInstanceFactory>(ctx =>
                    {
                        var c = ctx.Resolve<IComponentContext>();
                        return t =>
                        {
                            if (t.GenericTypeArguments.Any())
                            {
                                var apiCommmandType = t.GenericTypeArguments[0];

                                // API命令按照登记的作者名称去寻找
                                if (apiCommmandType.IsAssignableTo<IApiMahuaCommand>())
                                {
                                    var apiHandlerName = MahuaApiRegistrations.GetHangdlerAuthorName(apiCommmandType);
                                    return c.TryResolveKeyed(apiHandlerName, t, out var oo) ? oo : null;
                                }
                            }
                            return c.TryResolve(t, out var o) ? o : null;
                        };
                    })
                    .InstancePerLifetimeScope();

                // notification handlers
                builder
                    .Register<MultiInstanceFactory>(ctx =>
                    {
                        var c = ctx.Resolve<IComponentContext>();
                        return t => (IEnumerable<object>)c.Resolve(typeof(IEnumerable<>).MakeGenericType(t));
                    })
                    .InstancePerLifetimeScope();
                Debug("命令处理中心注册完毕。");
                var container = builder.Build();
                Debug("构建Container完毕。");
                Debug("插件已经初始化成功。");
                _container = container;
                var mahuaRobot = new MahuaRobotManagerImpl(container);
                MahuaRobotManager.Instance = mahuaRobot;
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        public byte[] Handle(byte[] cmd, string cmdTypeFullName, string resultTypeFullName)
        {
            WriteDiagnostics(() => cmd);
            using (var robotSession = MahuaRobotManager.Instance.CreateSession())
            {
                var lifetimeScope = robotSession.LifetimeScope;
                SetContainer(lifetimeScope);
                var center = lifetimeScope.Resolve<ICommandCenter>();
                var cmdType = GetMahuaType(cmdTypeFullName);
                var resultType = GetMahuaType(resultTypeFullName);
                Func<object, object[], object> invoke =
                    _commandCenterHandleWithResultMethod.MakeGenericMethod(cmdType, resultType).Invoke;
                var handler = WithResultHandlers
                    .GetOrAdd(cmdType, invoke);
                var re = handler(center, new[] { GlobalCache.CrossDoaminSerializer.Deserialize(cmd, cmdType) });
                var rejson = GlobalCache.CrossDoaminSerializer.Serialize(re, resultType);
                WriteDiagnostics(() => rejson);
                return rejson;
            }
        }

        public void Handle(byte[] cmd, string cmdTypeFullName)
        {
            WriteDiagnostics(() => cmd);
            using (var robotSession = MahuaRobotManager.Instance.CreateSession())
            {
                var lifetimeScope = robotSession.LifetimeScope;
                SetContainer(lifetimeScope);
                var center = lifetimeScope.Resolve<ICommandCenter>();
                var cmdType = GetMahuaType(cmdTypeFullName);
                var handler = VoidResultHandlers
                    .GetOrAdd(cmdType, _commandCenterHandleMethod.MakeGenericMethod(cmdType).Invoke);
                handler(center, new[] { GlobalCache.CrossDoaminSerializer.Deserialize(cmd, cmdType) });
            }
        }

        private static void Debug(string msg)
        {
            Logger.Debug(msg);
        }

        private static Type GetMahuaType(string typeName, MahuaPlatform? mahuaPlatform = null)
        {
            var p = mahuaPlatform ?? MahuaGlobal.CurrentPlatform;
            var re = CommandAndResultTypes
                .GetOrAdd($"{typeName}, Newbe.Mahua.{p:G}", typeStr => Type.GetType(typeStr, true, true));
            return re;
        }

        private static readonly ConcurrentDictionary<Type, Func<object, object[], object>> WithResultHandlers =
            new ConcurrentDictionary<Type, Func<object, object[], object>>();

        private static readonly ConcurrentDictionary<string, Type> CommandAndResultTypes =
            new ConcurrentDictionary<string, Type>();

        private static readonly ConcurrentDictionary<Type, Func<object, object[], object>> VoidResultHandlers =
            new ConcurrentDictionary<Type, Func<object, object[], object>>();

        private static readonly ILog Logger = LogProvider.For<CrossAppDomainPluginLoader>();

        private IContainer _container;

        private readonly MethodInfo _commandCenterHandleWithResultMethod =
            typeof(ICommandCenter)
                .GetMethod(nameof(ICommandCenter.HandleWithResult));

        private readonly MethodInfo _commandCenterHandleMethod =
            typeof(ICommandCenter)
                .GetMethod(nameof(ICommandCenter.Handle));

        private static void WriteDiagnostics(Func<byte[]> action)
        {
            if (MahuaGlobal.DiagnosticsConvertion.EnableDiagnostics)
            {
                var re = action?.Invoke();
                if (re != null)
                {
                    Debug($"{re.GetType().FullName} {MessagePackSerializer.ToJson(re)}");
                }
            }
        }

        private void SetContainer(ILifetimeScope container)
        {
            var api = container.Resolve<IMahuaApi>();
            api.SetLifetimeScope(container);
            api.SetSourceContainer(_container);
        }
    }
}
