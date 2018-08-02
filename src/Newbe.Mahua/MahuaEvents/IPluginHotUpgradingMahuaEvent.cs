using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 开始插件热更新事件
    /// </summary>
    [Description("开始插件热更新事件")]
    public interface IPluginHotUpgradingMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        void HotUpgrading(PluginHotUpgradingContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PluginHotUpgradingContext
    {
        /// <summary>
        /// 若需要取消热更新，则编辑此值为 true
        /// </summary>
        public bool Canceled { get; set; } = false;

        /// <summary>
        /// 取消原因，用于在日志中展示
        /// </summary>
        public string Reason { get; set; }
    }
}
