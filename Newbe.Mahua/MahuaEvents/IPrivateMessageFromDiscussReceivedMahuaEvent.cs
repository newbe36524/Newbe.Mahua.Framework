using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自讨论组成员的私聊消息接收事件
    /// </summary>
    [Description("来自讨论组成员的私聊消息接收事件")]
    public interface IPrivateMessageFromDiscussReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessage(PrivateMessageFromDiscussReceivedContext context);
    }

    public class PrivateMessageFromDiscussReceivedContext
    {
        public DateTime SendTime { get; set; }
        public string FromDiscuss { get; set; }
        public string Message { get; set; }
    }
}