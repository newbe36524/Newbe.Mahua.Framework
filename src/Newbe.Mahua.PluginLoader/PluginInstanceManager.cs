using Newbe.Mahua.Logging;
using System;
using System.Collections.Generic;
using W.Domains;

namespace Newbe.Mahua
{
    /// <summary>
    /// 插件实例管理器
    /// </summary>
    public static class PluginInstanceManager
    {
        public static IPluginLoader GetInstance(PluginFileInfo pluginFileInfo)
        {
            try
            {
                EnsureAppDomainInitialized(pluginFileInfo);
                return Instances[pluginFileInfo.Name];
            }
            catch (Exception e)
            {
                Logger.ErrorException(e.Message, e);
                throw;
            }
        }

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));

        private static IDictionary<string, IPluginLoader> Instances { get; } =
            new Dictionary<string, IPluginLoader>();

        private static void LogException(Exception e)
        {
            Logger.ErrorException(e.Message, e);
            Logger.Error(e.StackTrace);
        }

        private static void EnsureAppDomainInitialized(PluginFileInfo pluginFileInfo)
        {
            var pluginInfoName = pluginFileInfo.Name;
            if (Instances.ContainsKey(pluginInfoName))
            {
                return;
            }
            Logger.Info($"当前机器人平台为：{MahuaGlobal.CurrentPlatform:G}");
            Logger.Info("开始加载插件");
            try
            {
                Logger.Debug(pluginFileInfo.ToString());
                Logger.Debug($"当前插件名称为{pluginInfoName}");
                var domainLoader = new DomainLoader(pluginInfoName, pluginFileInfo.PluginEntyPointDirectory, true);
                Logger.Debug($"创建AppDomain进行加载插件:{pluginInfoName}");
                domainLoader.Load();
                Logger.Debug("开始创建透明代理");
                var loader = domainLoader.Create<IPluginLoader>(typeof(CrossAppDomainPluginLoader).FullName);
                Logger.Debug(
                    $"透明代理创建完毕，类型为{loader.GetType().FullName}，将开始调用{nameof(CrossAppDomainPluginLoader.LoadPlugin)}方法");
                if (!loader.LoadPlugin(pluginFileInfo.PluginEntryPointDllFullFilename))
                {
                    throw new PluginLoadException(pluginInfoName, loader.Message);
                }
                Instances.Add(pluginInfoName, loader);
            }
            catch (Exception e)
            {
                var inner = e;
                while (inner != null)
                {
                    LogException(inner);
                    inner = inner.InnerException;
                }
                throw;
            }
        }
    }
}
