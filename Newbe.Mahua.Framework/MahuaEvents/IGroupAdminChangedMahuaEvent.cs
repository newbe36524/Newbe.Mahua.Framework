using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupAdminChangedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminChange(GroupAdminChangeType groupAdminChangeType, DateTime sendTime, long fromGroup,
            long toQq);
    }
}