using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群成员增多事件
    /// </summary>
    [Description("群成员增多事件")]
    public interface IGroupMemberIncreasedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberIncreased(GroupMemberIncreasedContext context);
    }

    public class GroupMemberIncreasedContext
    {
        public DateTime SendTime { get; set; }
        public GroupMemberIncreasedReason GroupMemberIncreasedReason { get; set; }
        public string FromGroup { get; set; }
        public string FromQq { get; set; }
        public string ToQq { get; set; }
    }
}