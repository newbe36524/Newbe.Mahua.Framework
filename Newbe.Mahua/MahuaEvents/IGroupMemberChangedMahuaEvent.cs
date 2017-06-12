using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群成员变更事件
    /// </summary>
    [Description("群成员变更事件")]
    public interface IGroupMemberChangedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupMemberChanged(GroupMemberChangedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupMemberChangedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 管理员变更类型
        /// </summary>
        public GroupMemberChangedType GroupMemberChangedType { get; set; }

        /// <summary>
        /// 事件所属群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 入群或离开的Qq
        /// </summary>
        public string JoinedOrLeftQq { get; set; }
    }
}