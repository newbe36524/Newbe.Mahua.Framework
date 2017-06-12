using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 入群申请接收事件
    /// </summary>
    [Description("入群申请接收事件")]
    public interface IGroupJoiningRequestReceivedMahuaEvent : IMahuaEvent
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
    public class GroupJoiningRequestReceivedContext
    {
        /// <summary>
        /// 入群申请Id，用于处理此申请的唯一Id
        /// </summary>
        public string GroupJoiningRequestId { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 申请进入的群
        /// </summary>
        public string ToGroup { get; set; }

        /// <summary>
        /// 申请者QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 申请附加消息
        /// </summary>
        public string Message { get; set; }
    }
}