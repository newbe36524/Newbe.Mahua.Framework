using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群成员减少事件
    /// </summary>
    [Description("群成员减少事件")]
    public interface IGroupMemberDecreasedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberDecreased(GroupMemberDecreasedContext context);
    }

    public class GroupMemberDecreasedContext
    {
        public DateTime SendTime { get; set; }
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }
        public string FromGroup { get; set; }
        public string FromQq { get; set; }
        public string ToQq { get; set; }
    }
}