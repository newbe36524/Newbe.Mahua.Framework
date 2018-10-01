using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自好友的私聊消息接收事件
    /// </summary>
    [Description("来自好友的私聊消息接收事件")]
    public interface IPrivateMessageFromFriendReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PrivateMessageFromFriendReceivedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 来自QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        public long MessageId { get; set; }
    }
}