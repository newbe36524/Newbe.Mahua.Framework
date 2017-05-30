using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IFriendAddedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendsAdded(
            FriendAddedMahuaEventContext friendAddedMahuaEventContext);
    }

    public class FriendAddedMahuaEventContext
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
    }
}