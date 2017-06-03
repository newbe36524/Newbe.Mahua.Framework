using System;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IGroupMemberChangedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberChanged(GroupMemberChangedContext context);
    }

    public class GroupMemberChangedContext
    {
        public DateTime SendTime { get; set; }
        public GroupMemberChangedType GroupMemberChangedType { get; set; }
        public long FromGroup { get; set; }
        public long ToQq { get; set; }
    }
}