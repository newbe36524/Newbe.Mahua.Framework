using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newbe.Mahua.Framework.Logging;
using Newbe.Mahua.Framework.PluginLoader;

namespace Newbe.Mahua.Framework
{
    /// <summary>
    /// 插件实例管理器
    /// </summary>
    public static class PluginInstanceManager
    {
        private static IDictionary<string, CrossAppDomainPluginLoader> Instances { get; } =
            new Dictionary<string, CrossAppDomainPluginLoader>();

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));


        static PluginInstanceManager()
        {
            Logger.Info("开始加载插件");
            try
            {
                var pluginInfo = GetPluginInfo();
                pluginInfo.ValidateFiles();
                Logger.Debug($"当前插件名称为{pluginInfo.Name}");
                var appDomainSetup = new AppDomainSetup
                {
                    DisallowBindingRedirects = false,
                    ApplicationBase = pluginInfo.PluginEntyPointDirectory
                };
                if (File.Exists(pluginInfo.PluginEntryPointConfigFullFilename))
                {
                    appDomainSetup.ConfigurationFile = pluginInfo.PluginEntryPointConfigFullFilename;
                }
                Logger.Debug($"创建AppDomain进行加载插件:{pluginInfo.Name}");
                var domain = AppDomain.CreateDomain(pluginInfo.Name, AppDomain.CurrentDomain.Evidence,
                    appDomainSetup);
                domain.Load(new AssemblyName
                {
                    CodeBase = pluginInfo.PluginEntryPointDllFullFilename,
                });
                Logger.Debug("开始创建透明代理");
                var objectHandle = domain.CreateInstanceFrom("Newbe.Mahua.Framework.PluginLoader.dll",
                    typeof(CrossAppDomainPluginLoader).FullName);
                var loader = (CrossAppDomainPluginLoader) objectHandle.Unwrap();
                Logger.Debug(
                    $"透明代理创建完毕，类型为{loader.GetType().FullName}，将开始调用{nameof(CrossAppDomainPluginLoader.LoadPlugin)}方法");
                if (!loader.LoadPlugin(pluginInfo.PluginEntryPointDllFullFilename))
                {
                    throw new PluginLoadException(pluginInfo.Name, loader.Message);
                }
                Instances.Add(pluginInfo.Name, loader);
                IPluginInfo plugin = loader;
                Logger.Debug($"插件加载完毕:{pluginInfo.Name},AppId:{plugin.Id},ApiVersion:{plugin.Version}");
            }
            catch (Exception e)
            {
                Logger.ErrorException(e.Message, e);
                var inner = e.InnerException;
                while (inner != null)
                {
                    Logger.ErrorException(e.Message, e);
                    inner = inner.InnerException;
                }
                throw;
            }
        }

        private static string GetPluginName()
        {
            return Path.GetFileNameWithoutExtension(typeof(PluginInstanceManager).Assembly.CodeBase);
        }


        private static PluginInfo GetPluginInfo()
        {
            var pluginApiExpDll = typeof(PluginInstanceManager).Assembly.CodeBase;
            var pluginName = Path.GetFileNameWithoutExtension(pluginApiExpDll);
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var dllDir = Path.GetFullPath(Path.Combine(baseDir, pluginName));
            var re = new PluginInfo
            {
                Name = pluginName,
                PluginApiExporterRuntimeFullpath = pluginApiExpDll,
                PluginEntyPointDirectory = dllDir,
                PluginEntryPointDllFullFilename = Path.Combine(dllDir, $"{pluginName}.dll"),
                PluginEntryPointConfigFullFilename = Path.Combine(dllDir, $"{pluginName}.dll.config"),
            };
            return re;
        }

        internal static IPluginBase GetInstance()
        {
            try
            {
                return Instances[GetPluginName()];
            }
            catch (Exception e)
            {
                Logger.ErrorException(e.Message, e);
                throw;
            }
        }
    }
}