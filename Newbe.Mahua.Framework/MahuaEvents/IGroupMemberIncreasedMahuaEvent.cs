using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
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