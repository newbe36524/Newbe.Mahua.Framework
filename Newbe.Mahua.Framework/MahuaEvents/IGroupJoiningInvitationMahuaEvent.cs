using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupJoiningInvitationMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(GroupJoiningRequestContext context);
    }

    public class GroupJoiningInvitationContext
    {
        public string GroupJoiningInvitationId { get; set; }
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}