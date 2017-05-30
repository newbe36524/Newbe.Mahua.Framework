using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到来自讨论组的私聊消息
    /// </summary>
    public interface IPrivateMessageFromDiscussGroupReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessage(PrivateMessageFromDiscussGroupReceivedContext context);
    }

    public class PrivateMessageFromDiscussGroupReceivedContext
    {
        public DateTime SendTime { get; set; }
        public long DiscussGroupNum { get; set; }
        public string Message { get; set; }
    }
}