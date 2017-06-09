using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群成员变更事件
    /// </summary>
    [Description("群成员变更事件")]
    public interface IGroupMemberChangedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberChanged(GroupMemberChangedContext context);
    }

    public class GroupMemberChangedContext
    {
        public DateTime SendTime { get; set; }
        public GroupMemberChangedType GroupMemberChangedType { get; set; }
        public string FromGroup { get; set; }
        public string ToQq { get; set; }
    }
}