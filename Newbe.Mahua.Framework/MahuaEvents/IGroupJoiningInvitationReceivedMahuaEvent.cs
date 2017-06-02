using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupJoiningInvitationReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(GroupJoiningRequestReceivedContext receivedContext);
    }

    public class GroupJoiningInvitationReceivedContext
    {
        public string GroupJoiningInvitationId { get; set; }
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}