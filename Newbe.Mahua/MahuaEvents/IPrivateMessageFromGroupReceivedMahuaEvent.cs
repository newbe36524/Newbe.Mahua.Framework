using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自群成员的私聊消息接收事件
    /// </summary>
    [Description("来自群成员的私聊消息接收事件")]
    public interface IPrivateMessageFromGroupReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupMessage(PrivateMessageFromGroupReceivedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PrivateMessageFromGroupReceivedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 来自群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 消息发送者
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 事件内容
        /// </summary>
        public string Message { get; set; }
    }
}