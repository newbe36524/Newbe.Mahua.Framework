using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
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