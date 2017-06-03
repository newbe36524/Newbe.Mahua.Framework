using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自群成员的私聊消息接收事件
    /// </summary>
    [Description("来自群成员的私聊消息接收事件")]
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