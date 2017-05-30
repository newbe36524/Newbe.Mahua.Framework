using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到来自讨论组的私聊消息
    /// </summary>
    public interface IPrivateMessageFromDiscussGroupReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessage(DateTime sendTime, long discussGroupNum, string msg);
    }
}