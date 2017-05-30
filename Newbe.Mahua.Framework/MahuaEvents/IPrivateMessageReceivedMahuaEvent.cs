using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到私聊消息
    /// </summary>
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