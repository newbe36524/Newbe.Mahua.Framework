using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群管理员变更事件
    /// </summary>
    [Description("群管理员变更事件")]
    public interface IGroupAdminChangedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupAdminChange(GroupAdminChangedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupAdminChangedContext
    {
        /// <summary>
        /// 群管理员变更情况
        /// </summary>
        public GroupAdminChangeType GroupAdminChangeType { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 发生事件所属群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 被变更的QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}