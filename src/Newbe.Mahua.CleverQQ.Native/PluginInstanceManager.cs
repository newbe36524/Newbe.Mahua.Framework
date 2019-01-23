namespace Newbe.Mahua.CleverQQ.Native
{
    internal static class PluginInstanceManager
    {
        private static bool _initialized;

        public static IMahuaCenter GetInstance()
        {
            if (!_initialized)
            {
                var pluginInfo = PluginInfoProvider.GetPluginInfo();
                Mahua.PluginInstanceManager.EnsureAppDomainInitialized(pluginInfo);
                _initialized = true;
            }

            return Mahua.PluginInstanceManager.GetInstance();
        }
    }
}