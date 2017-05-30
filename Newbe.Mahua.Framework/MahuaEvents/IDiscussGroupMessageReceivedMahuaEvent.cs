using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到讨论组消息
    /// </summary>
    public interface IDiscussGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessage(DateTime sendTime, long discussGroupNum, string msg);
    }
}