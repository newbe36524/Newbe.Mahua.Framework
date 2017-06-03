using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 插件被禁用事件
    /// </summary>
    [Description("插件被禁用事件")]
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