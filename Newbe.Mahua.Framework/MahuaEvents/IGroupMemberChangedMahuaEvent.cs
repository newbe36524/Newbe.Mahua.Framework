using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
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