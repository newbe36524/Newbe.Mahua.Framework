using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IDiscussGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessageReceived(DiscussGroupMessageReceivedMahuaEventContext context);
    }

    public class DiscussGroupMessageReceivedMahuaEventContext
    {
        public DateTime SendTime { get; set; }
        public long FromDiscussGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}