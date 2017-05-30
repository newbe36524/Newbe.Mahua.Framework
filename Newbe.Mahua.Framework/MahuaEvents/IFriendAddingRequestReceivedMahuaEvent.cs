using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IFriendAddingRequestReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendsAdded(
            FriendAddingRequestReceivedMahuaEventContext friendAddingRequestReceivedMahuaEventContext);
    }

    public class FriendAddingRequestReceivedMahuaEventContext
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
    }
}