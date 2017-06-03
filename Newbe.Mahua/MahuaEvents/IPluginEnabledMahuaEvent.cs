using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 插件被启用事件
    /// </summary>
    [Description("插件被启用事件")]
    public interface IPluginEnabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 插件被启用
        /// </summary>
        /// <param name="context"></param>
        void Enabled(PluginEnabledContext context);
    }

    public class PluginEnabledContext
    {
    }
}