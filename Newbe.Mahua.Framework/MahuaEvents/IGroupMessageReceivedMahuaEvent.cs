using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMessage(GroupMessageReceivedContext context);
    }

    public class GroupMessageReceivedContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string FromAnonymous { get; set; }
        public string Message { get; set; }
    }
}