using System;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 接受到来自讨论组的私聊消息
    /// </summary>
    public interface IPrivateMessageFromDiscussReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessage(PrivateMessageFromDiscussReceivedContext context);
    }

    public class PrivateMessageFromDiscussReceivedContext
    {
        public DateTime SendTime { get; set; }
        public long FromDiscuss { get; set; }
        public string Message { get; set; }
    }
}