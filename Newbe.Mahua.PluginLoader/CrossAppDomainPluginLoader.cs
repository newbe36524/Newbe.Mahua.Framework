using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using Autofac;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua
{
    public class CrossAppDomainPluginLoader : MarshalByRefObject, IPluginLoader
    {
        private static readonly ILog Logger = LogProvider.For<CrossAppDomainPluginLoader>();
        internal static readonly int DefaultInitializeLeaseTimeInSeconds = 0;
        private IContainer _container;

        private static void Debug(string msg)
        {
            Logger.Debug(msg);
#if CrossDomainLog
            File.AppendAllLines(Path.Combine(Path.GetTempPath(), "Newbe.Mahua.log"), new[] {msg});
#endif
        }

        public override object InitializeLifetimeService()
        {
            var lease = (ILease) base.InitializeLifetimeService();
            System.Diagnostics.Debug.Assert(lease != null, "lease != null");
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(DefaultInitializeLeaseTimeInSeconds);
            }
            return lease;
        }

        public string Message { get; private set; }

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
                Debug($"程序集加载完毕,开始构建Container");
                var superBuilder = new ContainerBuilder();
                superBuilder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).AsImplementedInterfaces()
                    .AsSelf();
                var superContainer = superBuilder.Build();
                var subBuilderRegisters = superContainer.Resolve<IMahuaModule[]>().ToArray();
                var builder = new ContainerBuilder();
                foreach (var autofacContainerBuilder in subBuilderRegisters)
                {
                    var modules = autofacContainerBuilder.GetModules();
                    foreach (var module in modules)
                    {
                        builder.RegisterModule(module);
                    }
                }
                var container = builder.Build();
                _container = container;
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        public void SendCommand(MahuaCommand command)
        {
            using (var beginLifetimeScope = _container.BeginLifetimeScope())
            {
                var center = beginLifetimeScope.Resolve<ICommandCenter>();
                center.Handle(command);
            }
        }

        public void SendCommandWithResult(MahuaCommand command, out MahuaCommandResult mahuaCommandResult)
        {
            using (var beginLifetimeScope = _container.BeginLifetimeScope())
            {
                var center = beginLifetimeScope.Resolve<ICommandCenter>();
                center.Handle(command, out mahuaCommandResult);
            }
        }
    }
}