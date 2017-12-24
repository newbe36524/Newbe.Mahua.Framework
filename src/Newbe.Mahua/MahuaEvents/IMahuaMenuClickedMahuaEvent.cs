using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 菜单点击事件
    /// </summary>
    [Description("菜单点击事件")]
    public interface IMahuaMenuClickedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessManhuaMenuClicked(MahuaMenuClickedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class MahuaMenuClickedContext
    {
        /// <summary>
        /// 被点击的菜单
        /// </summary>
        public MahuaMenu Menu { get; set; }

        /// <summary>
        /// 点击时间
        /// </summary>
        public DateTime ClickedTime { get; set; }
    }
}
