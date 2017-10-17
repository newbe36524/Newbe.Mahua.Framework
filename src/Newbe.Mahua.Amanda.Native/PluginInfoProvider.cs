using System;
using System.IO;

namespace Newbe.Mahua.Amanda.Native
{
    internal static class PluginInfoProvider
    {
        public static PluginFileInfo GetPluginInfo()
        {
            var pluginApiExpDll = typeof(AmandaMahuaModule).Assembly.CodeBase;
            var pluginName = Path.GetFileNameWithoutExtension(pluginApiExpDll).Replace(".plugin", string.Empty);
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var dllDir = Path.GetFullPath(Path.Combine(baseDir, pluginName));
            var re = new PluginFileInfo
            {
                Name = pluginName,
                PluginApiExporterRuntimeFullpath = pluginApiExpDll,
                PluginEntyPointDirectory = dllDir,
                PluginEntryPointDllFullFilename = Path.Combine(dllDir, $"{pluginName}.dll"),
                PluginEntryPointConfigFullFilename = Path.Combine(dllDir, $"{pluginName}.dll.config"),
            };
            return re;
        }
    }
}
