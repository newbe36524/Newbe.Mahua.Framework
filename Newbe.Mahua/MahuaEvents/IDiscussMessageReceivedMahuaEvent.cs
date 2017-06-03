using System;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IDiscussMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessageReceived(DiscussMessageReceivedMahuaEventContext context);
    }

    public class DiscussMessageReceivedMahuaEventContext
    {
        public DateTime SendTime { get; set; }
        public long FromDiscuss { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}