using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 解除群管理员事件
    /// </summary>
    [Description("解除群管理员事件")]
    public interface IGroupAdminDisabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupAdminDisabled(GroupAdminDisabledContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupAdminDisabledContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 事件所属群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 被解除管理员的QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}