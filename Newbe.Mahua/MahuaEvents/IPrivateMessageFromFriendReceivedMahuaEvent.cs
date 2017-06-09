using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自好友的私聊消息接收事件
    /// </summary>
    [Description("来自好友的私聊消息接收事件")]
    public interface IPrivateMessageFromFriendReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context);
    }

    public class PrivateMessageFromFriendReceivedContext
    {
        public DateTime SendTime { get; set; }
        public string FromQq { get; set; }
        public string Message { get; set; }
    }
}