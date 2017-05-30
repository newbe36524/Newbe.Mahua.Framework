namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 插件被启用
    /// </summary>
    public interface IPluginEnabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 插件被启用
        /// </summary>
        void Enabled();
    }
}