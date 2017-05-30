using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupAdminEnabledMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminEnabled(GroupAdminEnabledContext context);
    }

    public class GroupAdminEnabledContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long ToQq { get; set; }
    }
}