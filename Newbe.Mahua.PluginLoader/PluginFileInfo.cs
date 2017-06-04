using System;

namespace Newbe.Mahua
{
    /// <summary>
    /// 插件信息
    /// </summary>
    public class PluginFileInfo
    {
        /// <summary>
        /// 插件名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 运行时插件dll路径，CQP在运行时会将插件dll复制到tmp目录运行，这个变量就指向这个路径
        /// </summary>
        public string PluginApiExporterRuntimeFullpath { get; set; }

        /// <summary>
        /// 插件真实的入口dll文件路径
        /// </summary>
        public string PluginEntryPointDllFullFilename { get; set; }

        /// <summary>
        /// 插件Dll所在文件夹
        /// </summary>
        public string PluginEntyPointDirectory { get; set; }

        /// <summary>
        /// 插件的app.config文件路径
        /// </summary>
        public string PluginEntryPointConfigFullFilename { get; set; }

        public override string ToString()
        {
            return $"{Environment.NewLine} {nameof(Name)}: {Name}," +
                   $"{Environment.NewLine} {nameof(PluginApiExporterRuntimeFullpath)}: {PluginApiExporterRuntimeFullpath}," +
                   $"{Environment.NewLine} {nameof(PluginEntryPointDllFullFilename)}: {PluginEntryPointDllFullFilename}," +
                   $"{Environment.NewLine} {nameof(PluginEntyPointDirectory)}: {PluginEntyPointDirectory}," +
                   $" {Environment.NewLine} {nameof(PluginEntryPointConfigFullFilename)}: {PluginEntryPointConfigFullFilename}";
        }
    }
}