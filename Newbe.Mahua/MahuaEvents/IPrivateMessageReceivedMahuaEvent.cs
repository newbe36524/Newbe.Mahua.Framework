using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 私聊消息接收事件
    /// </summary>
    [Description("来自群成员的私聊消息接收事件")]
    public interface IPrivateMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessPrivateMessage(PrivateMessageReceivedContext context);
    }

    public class PrivateMessageReceivedContext
    {
        public PrivateMessageFromType PrivateMessageFromType { get; set; }
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}