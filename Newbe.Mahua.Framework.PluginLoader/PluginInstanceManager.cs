using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newbe.Mahua.Framework.Logging;
using W.Domains;

namespace Newbe.Mahua.Framework
{
    /// <summary>
    /// 插件实例管理器
    /// </summary>
    public static class PluginInstanceManager
    {
        private static IDictionary<string, IPluginLoader> Instances { get; } =
            new Dictionary<string, IPluginLoader>();

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));


        static PluginInstanceManager()
        {
            Logger.Info("开始加载插件");
            try
            {
                var pluginInfo = GetPluginInfo();
                pluginInfo.ValidateFiles();
                Logger.Debug($"当前插件名称为{pluginInfo.Name}");
                var domainLoader = new DomainLoader(pluginInfo.Name, pluginInfo.PluginEntyPointDirectory, true);
                Logger.Debug($"创建AppDomain进行加载插件:{pluginInfo.Name}");
                domainLoader.Load();
                Logger.Debug("开始创建透明代理");
                var loader = domainLoader.Create<IPluginLoader>(typeof(CrossAppDomainPluginLoader).FullName);
                Logger.Debug(
                    $"透明代理创建完毕，类型为{loader.GetType().FullName}，将开始调用{nameof(CrossAppDomainPluginLoader.LoadPlugin)}方法");
                if (!loader.LoadPlugin(pluginInfo.PluginEntryPointDllFullFilename))
                {
                    throw new PluginLoadException(pluginInfo.Name, loader.Message);
                }
                Instances.Add(pluginInfo.Name, loader);
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
            return "Newbe.Mahua.Plugins.Parrot";
        }


        private static PluginInfo GetPluginInfo()
        {
            var pluginApiExpDll = @"D:\Codes\kq\app\Newbe.Mahua.Plugins.Parrot.dll";
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

        public static IPluginLoader GetInstance()
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