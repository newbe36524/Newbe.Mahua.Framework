using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 好友申请接受事件
    /// </summary>
    [Description("好友申请接受事件")]
    public interface IFriendAddingRequestMahuaEvent : IMahuaEvent
    {
        void ProcessAddingFriendRequest(FriendAddingRequestContext context);
    }

    public class FriendAddingRequestContext
    {
        public string AddingFriendRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public string FromQq { get; set; }
        public string Message { get; set; }
    }
}