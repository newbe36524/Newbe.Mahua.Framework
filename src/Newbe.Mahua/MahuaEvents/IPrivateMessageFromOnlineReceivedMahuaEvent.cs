using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自在线状态的私聊消息接收事件
    /// </summary>
    [Description("来自在线状态的私聊消息接收事件")]
    public interface IPrivateMessageFromOnlineReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessOnlineMessage(PrivateMessageFromOnlineReceivedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PrivateMessageFromOnlineReceivedContext
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