using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IAddingFriendRequestMahuaEvent : IMahuaEvent
    {
        void ProcessAddingFriendRequest(AddingFriendRequestContext context);
    }

    public class AddingFriendRequestContext
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}