using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 已添加新好友事件
    /// </summary>
    [Description("已添加新好友事件")]
    public interface IFriendAddedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendsAdded(FriendAddedMahuaEventContext context);
    }

    public class FriendAddedMahuaEventContext
    {
        public DateTime SendTime { get; set; }
        public string FromQq { get; set; }
    }
}