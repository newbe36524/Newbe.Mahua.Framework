using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupAdminEnabledMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminEnabled(DateTime sendTime, long fromGroup, long toQq);
    }
}