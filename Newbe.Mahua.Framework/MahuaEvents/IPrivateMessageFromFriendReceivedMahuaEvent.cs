using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到好友的私聊消息
    /// </summary>
    public interface IPrivateMessageFromFriendReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendMessage(DateTime sendTime, long fromQq, string msg);
    }
}