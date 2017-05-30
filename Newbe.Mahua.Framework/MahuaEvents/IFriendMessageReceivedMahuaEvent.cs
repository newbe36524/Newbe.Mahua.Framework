using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到好友消息
    /// </summary>
    public interface IFriendMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessFriendMessage(DateTime sendTime, long fromQq, string msg);
    }
}