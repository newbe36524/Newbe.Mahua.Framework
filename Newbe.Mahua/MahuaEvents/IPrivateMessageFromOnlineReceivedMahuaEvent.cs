using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自在线状态的私聊消息接收事件
    /// </summary>
    [Description("来自在线状态的私聊消息接收事件")]
    public interface IPrivateMessageFromOnlineReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessOnlineMessage(PrivateMessageFromOnlineReceivedContext context);
    }

    public class PrivateMessageFromOnlineReceivedContext
    {
        public DateTime SendTime { get; set; }
        public string FromQq { get; set; }
        public string Message { get; set; }
    }
}