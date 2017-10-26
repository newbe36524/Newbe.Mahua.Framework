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
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessFriendsAdded(FriendAddedMahuaEventContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class FriendAddedMahuaEventContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 新好友QQ
        /// </summary>
        public string FromQq { get; set; }
    }
}