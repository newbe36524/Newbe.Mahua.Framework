using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到私聊消息
    /// </summary>
    public interface IPrivateMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessPrivateMessage(PrivateMessageFromType subType, DateTime sendTime, long fromQq, string msg);
    }
}