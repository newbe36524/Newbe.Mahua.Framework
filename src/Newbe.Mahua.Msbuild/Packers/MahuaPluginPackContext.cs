namespace Newbe.Mahua.Msbuild.Packers
{
    public class MahuaPluginPackContext
    {
        /// <summary>
        /// 项目文件夹
        /// </summary>
        public string ProjectDirectory { get; set; }

        /// <summary>
        /// 生成配置
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        public string NewbePluginName { get; set; }

        /// <summary>
        /// Package文件夹
        /// </summary>
        public string PackageDirectory { get; set; }
    }
}