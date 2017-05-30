using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到来自在线状态的私聊消息
    /// </summary>
    public interface IPrivateMessageFromOnlineReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessOnlineMessage(PrivateMessageFromOnlineReceivedContext context);
    }

    public class PrivateMessageFromOnlineReceivedContext
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}