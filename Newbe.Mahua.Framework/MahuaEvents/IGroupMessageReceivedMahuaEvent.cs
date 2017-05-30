using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMessage(DateTime sendTime, long fromGroup, long fromQq, string fromAnonymous, string msg);
    }
}