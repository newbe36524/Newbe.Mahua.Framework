using System;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IGroupMemberIncreasedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberIncreased(GroupMemberIncreasedContext context);
    }

    public class GroupMemberIncreasedContext
    {
        public DateTime SendTime { get; set; }
        public GroupMemberIncreasedReason GroupMemberIncreasedReason { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public long ToQq { get; set; }
    }
}