using System;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IGroupAdminDisabledMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminDisabled(GroupAdminDisabledContext context);
    }

    public class GroupAdminDisabledContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long ToQq { get; set; }
    }
}