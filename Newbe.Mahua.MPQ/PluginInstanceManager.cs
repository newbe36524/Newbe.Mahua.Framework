namespace Newbe.Mahua.MPQ
{
    internal static class PluginInstanceManager
    {
        public static IPluginLoader GetInstance()
        {
            var pluginInfo = PluginInfoProvider.GetPluginInfo();
            return Mahua.PluginInstanceManager.GetInstance(pluginInfo);
        }
    }
}