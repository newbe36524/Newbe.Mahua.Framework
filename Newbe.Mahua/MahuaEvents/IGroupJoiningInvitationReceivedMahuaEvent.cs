using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 入群邀请接收事件
    /// </summary>
    [Description("入群邀请接收事件")]
    public interface IGroupJoiningInvitationReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="receivedContext"></param>
        void ProcessJoinGroupRequest(GroupJoiningRequestReceivedContext receivedContext);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupJoiningInvitationReceivedContext
    {
        /// <summary>
        /// 入群邀请Id，用于处理此请求时的唯一Id
        /// </summary>
        public string GroupJoiningInvitationId { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 邀请进入的目标群
        /// </summary>
        public string ToGroup { get; set; }

        /// <summary>
        /// 邀请人QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 邀请附加消息
        /// </summary>
        public string Message { get; set; }
    }
}