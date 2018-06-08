namespace Newbe.Mahua
{
    /// <summary>
    /// 插件信息
    /// </summary>
    public interface IPluginInfo
    {
        /// <summary>
        /// 版本
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Id，插件唯一标识
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// 插件描述信息
        /// </summary>
        string Description { get; set; }
    }
}
