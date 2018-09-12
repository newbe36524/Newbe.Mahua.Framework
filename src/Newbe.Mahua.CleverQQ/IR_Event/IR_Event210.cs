using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 某人成为管理员
    /// </summary>
    public class IR_Event210 : IIR_Event
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;

        public IR_Event210(
            IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
        }

        public int IR_Event { get; } = 210;

        public void Handle(IR_EventInput eventFunInput)
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
