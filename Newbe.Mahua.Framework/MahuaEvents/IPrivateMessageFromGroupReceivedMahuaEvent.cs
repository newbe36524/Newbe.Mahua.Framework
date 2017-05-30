using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到来自群成员的私聊消息
    /// </summary>
    public interface IPrivateMessageFromGroupReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMessage(DateTime sendTime, long groupNum, string msg);
    }
}