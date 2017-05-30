namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 插件被禁用
    /// </summary>
    public interface IPluginDisabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 插件被禁用
        /// </summary>
        void Disable(PluginDisabledContext context);
    }

    public class PluginDisabledContext
    {

    }
}