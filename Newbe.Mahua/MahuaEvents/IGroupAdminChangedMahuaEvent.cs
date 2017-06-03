using System;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IGroupAdminChangedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminChange(GroupAdminChangedContext context);
    }

    public class GroupAdminChangedContext
    {
        public GroupAdminChangeType GroupAdminChangeType { get; set; }
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long ToQq { get; set; }
    }
}