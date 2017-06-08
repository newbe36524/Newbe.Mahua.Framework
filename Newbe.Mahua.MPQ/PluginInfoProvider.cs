using System;
using System.IO;

namespace Newbe.Mahua.MPQ
{
    internal static class PluginInfoProvider
    {
        public static PluginFileInfo GetPluginInfo()
        {
            var pluginApiExpDll = typeof(MpqMahuaModule).Assembly.CodeBase;
            var pluginName = Path.GetFileNameWithoutExtension(pluginApiExpDll).Replace(".xx", string.Empty);
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