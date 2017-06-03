using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群管理员变更事件
    /// </summary>
    [Description("群管理员变更事件")]
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