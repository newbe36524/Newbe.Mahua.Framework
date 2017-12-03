using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人成为管理员
    ///</summary>
    public class EventFunHandler2009 : IEventFunHandler
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;

        public EventFunHandler2009(
            IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
        }

        public int EventFun { get; } = 2009;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupAdminChangedMahuaEvents
                .Handle(x =>
                    x.ProcessGroupAdminChange(new GroupAdminChangedContext
                    {
                        FromGroup = eventFunInput.FromNum,
                        ToQq = eventFunInput.EventOperator,
                        GroupAdminChangeType = GroupAdminChangeType.Enabled,
                        SendTime = Clock.Now,
                    }));
            _groupAdminEnabledMahuaEvents
                .Handle(x =>
                    x.ProcessGroupAdminEnabled(new GroupAdminEnabledContext
                    {
                        FromGroup = eventFunInput.FromNum,
                        ToQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                    }));
        }
    }
}
