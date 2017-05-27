using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using Autofac;
using Newbe.Mahua.Framework.Logging;

namespace Newbe.Mahua.Framework
{
    public class CrossAppDomainPluginLoader : MarshalByRefObject, IPluginBase, IPluginInfo
    {
        private static readonly ILog Logger = LogProvider.For<CrossAppDomainPluginLoader>();
        internal static readonly int DefaultInitializeLeaseTimeInSeconds = 0;
        private IPluginBase _pluginBase;

        private static void Debug(string msg)
        {
            Logger.Debug(msg);
#if CrossDomainLog
            File.AppendAllLines(Path.Combine(Path.GetTempPath(), "Newbe.Mahua.Framework.log"), new[] {msg});
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
                Debug($"Container构建完毕，尝试获取{nameof(IPluginBase)}实现类");
                var impls = container.Resolve<IEnumerable<IPluginBase>>().ToArray();
                Debug($"实现类一共{impls.Length}个");
                _pluginBase = impls.First(x => !(x is CrossAppDomainPluginLoader));
                Debug($"获取到了{_pluginBase.GetType().Name}作为{nameof(IPluginBase)}的实现类，插件加载完毕");
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        public string Message { get; private set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
    }
}