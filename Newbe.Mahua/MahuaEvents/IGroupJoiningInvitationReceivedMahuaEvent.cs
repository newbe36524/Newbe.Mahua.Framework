using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 入群邀请接收事件
    /// </summary>
    [Description("入群邀请接收事件")]
    public interface IGroupJoiningInvitationReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(GroupJoiningRequestReceivedContext receivedContext);
    }

    public class GroupJoiningInvitationReceivedContext
    {
        public string GroupJoiningInvitationId { get; set; }
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}