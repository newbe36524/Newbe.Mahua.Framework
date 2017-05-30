using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到群消息
    /// </summary>
    public interface IGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMessage(DateTime sendTime, long groupNum, string msg);
    }
}