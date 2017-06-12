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
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessAddingFriendRequest(FriendAddingRequestContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class FriendAddingRequestContext
    {
        /// <summary>
        /// 添加好友请求Id，用于标识此请求的唯一Id
        /// </summary>
        public string AddingFriendRequestId { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 申请添加好友的QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 申请添加时的附加消息
        /// </summary>
        public string Message { get; set; }
    }
}