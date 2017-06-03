using System;

namespace Newbe.Mahua.MahuaEvents
{
    public interface IFriendAddingRequestMahuaEvent : IMahuaEvent
    {
        void ProcessAddingFriendRequest(FriendAddingRequestContext context);
    }

    public class FriendAddingRequestContext
    {
        public string AddingFriendRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}