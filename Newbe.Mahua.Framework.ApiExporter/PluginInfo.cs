using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.Framework.Logging;

namespace Newbe.Mahua.Framework
{
    /// <summary>
    /// 插件信息
    /// </summary>
    public class PluginInfo
    {
        private static readonly ILog Logger = LogProvider.For<PluginInfo>();

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
            return
                $"{nameof(Name)}: {Name}, {nameof(PluginApiExporterRuntimeFullpath)}: {PluginApiExporterRuntimeFullpath}, {nameof(PluginEntryPointDllFullFilename)}: {PluginEntryPointDllFullFilename}, {nameof(PluginEntyPointDirectory)}: {PluginEntyPointDirectory}, {nameof(PluginEntryPointConfigFullFilename)}: {PluginEntryPointConfigFullFilename}";
        }

        public void ValidateFiles()
        {
            Logger.Debug(ToString);
            if (!File.Exists(PluginEntryPointDllFullFilename))
            {
                throw new FileNotFoundException(
                    $"无法找到{Name}插件的入口Dll，需要将{Name}.dll及其依赖项复制到{PluginEntyPointDirectory}");
            }
        }
    }
}