using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IDiscussGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessage(DateTime sendTime, long fromDiscuss, long fromQq, string msg);
    }
}