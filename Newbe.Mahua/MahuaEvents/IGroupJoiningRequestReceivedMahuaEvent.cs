using System;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IGroupJoiningRequestReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(GroupJoiningRequestReceivedContext receivedContext);
    }

    public class GroupJoiningRequestReceivedContext
    {
        public string GroupJoiningRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public long ToGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}