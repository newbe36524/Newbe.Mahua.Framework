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

        /// <summary>
        /// 若<see cref="GroupMemberDecreasedReason"/>为<see cref="Enums.GroupMemberDecreasedReason.Kicked"/>则此值为操作的管理员QQ，否则为null
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 离开成员QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}