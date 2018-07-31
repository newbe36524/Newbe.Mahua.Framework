using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 插件热更新成功事件
    /// </summary>
    [Description("插件热更新成功事件")]
    public interface IPluginHotUpgradedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        void HotUpgraded(PluginHotUpgradedContext context);
    }


    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PluginHotUpgradedContext
    {
    }
}
