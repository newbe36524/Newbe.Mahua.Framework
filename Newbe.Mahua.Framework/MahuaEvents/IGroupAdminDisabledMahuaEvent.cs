using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupAdminDisabledMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminDisabled(DateTime sendTime, long fromGroup, long toQq);
    }
}