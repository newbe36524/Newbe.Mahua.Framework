using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using AutoMapper;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua
{
    public class PluginLoader : IPluginLoader
    {
        private static readonly ILog Logger = LogProvider.For<PluginLoader>();
        private IContainer _container;

        public void LoadPlugin(string pluginEntryPointDllFullFilename)
        {
            Logger.Debug($"开始加载插件程序集：{pluginEntryPointDllFullFilename}");
            AppDomain.CurrentDomain.Load(new AssemblyName
            {
                CodeBase = pluginEntryPointDllFullFilename
            });

            var directoryName = Path.GetDirectoryName(pluginEntryPointDllFullFilename);
            Debug.Assert(directoryName != null, nameof(directoryName) + " != null");

            var files = new[] {"Newbe.Mahua.OutputSenders.*.dll", "Newbe.Mahua.InputReceivers.*.dll"}
                .SelectMany(searchPattern => Directory.GetFiles(directoryName, searchPattern));
            foreach (var file in files)
            {
                AppDomain.CurrentDomain.Load(new AssemblyName
                {
                    CodeBase = file
                });
            }

            Logger.Debug("程序集加载完毕,开始构建Container");
            var mahuaModuleTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => x.IsClass && x.GetInterface(typeof(IMahuaModule).Name) != null)
                .ToArray();
            Logger.Debug($"共发现{mahuaModuleTypes.Length}个IMahuaModule");
            var builder = new ContainerBuilder();

            // register self
            builder.RegisterInstance(this)
                .As<IPluginLoader>()
                .As<IMahuaCenter>()
                .SingleInstance();

            foreach (var type in mahuaModuleTypes)
            {
                Debug.Assert(type != null, nameof(type) + " != null");
                var mahuaModule = (IMahuaModule) Activator.CreateInstance(type);
                var modules = mahuaModule.GetModules();
                Logger.Debug($"{type.FullName} 中发现了 {modules.Length} 个 Autofac.Module。");
                foreach (var module in modules)
                {
                    builder.RegisterModule(module);
                    Logger.Debug($"注册了 {module.GetType().FullName}");
                }
            }

            Logger.Debug("IMahuaModule扫描注册完毕。");

            _container = builder.Build();
            Logger.Debug("构建Container完毕。");

            Logger.Debug("开始异步启动消息接收器。");
            var mahuaInputReceiverFactory = _container.Resolve<IInputReceiverFactory>();
            var mahuaInputReceivers = mahuaInputReceiverFactory.Create();
            foreach (var mahuaInputReceiver in mahuaInputReceivers)
            {
                // 不等待消息接收器启动完毕
                mahuaInputReceiver.Start();
            }

            Logger.Debug("插件已经初始化成功。");
        }

        public Task HandleMahuaOutput(IOutput output)
        {
            using (var beginLifetimeScope = _container.BeginLifetimeScope())
            {
                var handler = beginLifetimeScope.Resolve<IOutputHandler>();
                return handler.Handle(output);
            }
        }

        public Task HandleMahuaInput(IInput input)
        {
            using (var beginLifetimeScope = _container.BeginLifetimeScope())
            {
                var handler = beginLifetimeScope.Resolve<IInputHandler>();
                return handler.Handle(input);
            }
        }
    }
}