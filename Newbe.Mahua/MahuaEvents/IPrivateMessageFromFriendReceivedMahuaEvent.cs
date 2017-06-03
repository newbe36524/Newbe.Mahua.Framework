using System;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 接受到好友的私聊消息
    /// </summary>
    public interface IPrivateMessageFromFriendReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context);
    }

    public class PrivateMessageFromFriendReceivedContext
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}