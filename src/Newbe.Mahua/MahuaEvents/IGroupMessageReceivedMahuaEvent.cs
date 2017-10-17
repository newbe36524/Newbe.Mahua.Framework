using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群消息接收事件
    /// </summary>
    [Description("群消息接收事件")]
    public interface IGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupMessage(GroupMessageReceivedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupMessageReceivedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 消息来源群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 消息发送者QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 匿名用户名称，非匿名发言时，该值为<see cref="string.Empty"/>
        /// </summary>
        public string FromAnonymous { get; set; }

        /// <summary>
        /// 群消息
        /// </summary>
        public string Message { get; set; }
    }
}