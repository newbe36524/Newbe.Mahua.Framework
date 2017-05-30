using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到在线状态消息
    /// </summary>
    public interface IOnlineMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessOnlineMessage(DateTime sendTime, long fromQq, string msg);
    }
}