using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群成员减少事件
    /// </summary>
    [Description("群成员减少事件")]
    public interface IGroupMemberDecreasedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupMemberDecreased(GroupMemberDecreasedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupMemberDecreasedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 群成员减少原因
        /// </summary>
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }

        /// <summary>
        /// 事件所属群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 若<see cref="GroupMemberDecreasedReason"/>为<see cref="Enums.GroupMemberDecreasedReason.Kicked"/>则此值为操作的管理员QQ，否则为null
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 离开成员QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}