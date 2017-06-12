using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群成员增多事件
    /// </summary>
    [Description("群成员增多事件")]
    public interface IGroupMemberIncreasedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupMemberIncreased(GroupMemberIncreasedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupMemberIncreasedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 入群原因
        /// </summary>
        public GroupMemberIncreasedReason GroupMemberIncreasedReason { get; set; }

        /// <summary>
        /// 事件所属群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 群员邀请者或者同意入群的管理员，取决于<see cref="GroupMemberIncreasedReason"/>
        /// </summary>
        public string InvitatorOrAdmin { get; set; }

        /// <summary>
        /// 已加入的QQ
        /// </summary>
        public string JoinedQq { get; set; }
    }
}