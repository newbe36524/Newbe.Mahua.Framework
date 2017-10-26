using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 讨论组消息接受事件
    /// </summary>
    [Description("讨论组消息接受事件")]
    public interface IDiscussMessageReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessDiscussGroupMessageReceived(DiscussMessageReceivedMahuaEventContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class DiscussMessageReceivedMahuaEventContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 发送消息QQ所属讨论组
        /// </summary>
        public string FromDiscuss { get; set; }

        /// <summary>
        /// 发送消息的QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }
    }
}