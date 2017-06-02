using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupJoiningRequestMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(GroupJoiningRequestContext context);
    }

    public class GroupJoiningRequestContext
    {
        public string GroupJoiningRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}