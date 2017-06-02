using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到来自群成员的私聊消息
    /// </summary>
    public interface IPrivateMessageFromGroupReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMessage(PrivateMessageFromGroupReceivedContext context);
    }

    public class PrivateMessageFromGroupReceivedContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public string Message { get; set; }
    }
}