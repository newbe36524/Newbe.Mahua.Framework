using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 入群申请接收事件
    /// </summary>
    [Description("入群申请接收事件")]
    public interface IGroupJoiningRequestReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(GroupJoiningRequestReceivedContext receivedContext);
    }

    public class GroupJoiningRequestReceivedContext
    {
        public string GroupJoiningRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public string ToGroup { get; set; }
        public string FromQq { get; set; }
        public string Message { get; set; }
    }
}