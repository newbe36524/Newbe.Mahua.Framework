using Newbe.Mahua.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Newbe.Mahua
{
    /// <summary>
    /// 插件实例管理器
    /// </summary>
    public static class PluginInstanceManager
    {
        static PluginInstanceManager()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainOnAssemblyResolve;
        }

        private static Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            var filename = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                FrameworkMainDllDirName,
                $"{args.Name.Split(',')[0]}.dll");
            return File.Exists(filename) ? Assembly.LoadFile(filename) : null;
        }

        private const string FrameworkMainDllDirName = "Newbe.Mahua.Plugin.Agent";
        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));
        private static readonly object PluginInitLocker = new object();

        public static IMahuaCenter GetInstance()
        {
            try
            {
                return _instance.PluginLoader;
            }
            catch (Exception e)
            {
                // ReSharper disable once InconsistentlySynchronizedField
                Logger.ErrorException(e.Message, e);
                throw;
            }
        }

        private static bool _initialized;
        private static PluginInstance _instance;

        public static void EnsureAppDomainInitialized(PluginFileInfo pluginFileInfo)
        {
            var pluginInfoName = pluginFileInfo.Name;
            if (_initialized)
            {
                return;
            }

            lock (PluginInitLocker)
            {
                if (_initialized)
                {
                    return;
                }

                Logger.Info($"current mahua platform ：{MahuaGlobal.CurrentPlatform:G}");
                Logger.Debug(pluginFileInfo.ToString());
                Logger.Debug($"plugin name is {pluginInfoName}");
                IPluginLoader loader = new PluginLoader();
                Logger.Debug($"loading plugin {pluginInfoName}");
                loader.LoadPlugin(pluginFileInfo.PluginEntryPointDllFullFilename);
                var pluginInstance = new PluginInstance
                {
                    PluginLoader = loader,
                    PluginFileInfo = pluginFileInfo,
                };
                _instance = pluginInstance;
                _initialized = true;
            }
        }

        private class PluginInstance
        {
            public PluginFileInfo PluginFileInfo { get; set; }
            public IPluginLoader PluginLoader { get; set; }
        }
    }
}