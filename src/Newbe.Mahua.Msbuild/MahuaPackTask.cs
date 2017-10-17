using System;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Newbe.Mahua.Msbuild.Packers;

namespace Newbe.Mahua.Msbuild
{
    /// <summary>
    /// Mahua插件打包任务
    /// </summary>
    public class MahuaPackTask : Task
    {
        /// <summary>
        /// 项目文件夹
        /// </summary>
        [Required]
        public string ProjectDirectory { get; set; }

        /// <summary>
        /// 生成配置
        /// </summary>
        [Required]
        public string Configuration { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [Required]
        public string MahuaPluginName { get; set; }

        /// <summary>
        /// Package文件夹
        /// </summary>
        [Required]
        public string PackageDirectory { get; set; }

        /// <summary>
        /// 需要打包的插件列表
        /// </summary>
        [Required]
        public string[] MahuaPlatforms { get; set; }

        public override bool Execute()
        {
            var context = new MahuaPluginPackContext
            {
                NewbePluginName = MahuaPluginName,
                PackageDirectory = PackageDirectory,
                ProjectDirectory = ProjectDirectory,
                Configuration = Configuration
            };
            IMahuaPluginPackerFactory factory = new MahuaPluginPackerFactory(new TaskLog(Log));
            return MahuaPlatforms.Select(x =>
                {
                    Enum.TryParse(x, true, out MahuaPlatform platform);
                    return platform;
                })
                .Select(mahuaPlatform => factory.Create(mahuaPlatform))
                .Select(mahuaPluginPacker => mahuaPluginPacker.Pack(context))
                .All(packResult => packResult);
        }
    }
}