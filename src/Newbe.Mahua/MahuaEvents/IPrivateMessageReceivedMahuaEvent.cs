using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 私聊消息接收事件
    /// </summary>
    [Description("私聊消息接收事件")]
    public interface IPrivateMessageReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessPrivateMessage(PrivateMessageReceivedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PrivateMessageReceivedContext
    {
        /// <summary>
        /// 私聊消息来源类型
        /// </summary>
        public PrivateMessageFromType PrivateMessageFromType { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 发送者QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }
    }
}