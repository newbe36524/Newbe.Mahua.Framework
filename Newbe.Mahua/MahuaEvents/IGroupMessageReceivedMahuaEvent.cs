using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群消息接收事件
    /// </summary>
    [Description("群消息接收事件")]
    public interface IGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMessage(GroupMessageReceivedContext context);
    }

    public class GroupMessageReceivedContext
    {
        public DateTime SendTime { get; set; }
        public string FromGroup { get; set; }
        public string FromQq { get; set; }
        public string FromAnonymous { get; set; }
        public string Message { get; set; }
    }
}