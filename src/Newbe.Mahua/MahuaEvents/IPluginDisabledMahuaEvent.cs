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
        /// 处理事件
        /// </summary>
        void Disable(PluginDisabledContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PluginDisabledContext
    {
    }
}