using System;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IGroupMemberDecreasedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberDecreased(GroupMemberDecreasedContext context);
    }

    public class GroupMemberDecreasedContext
    {
        public DateTime SendTime { get; set; }
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public long ToQq { get; set; }
    }
}