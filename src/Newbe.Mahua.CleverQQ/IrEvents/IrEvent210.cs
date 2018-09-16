using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 某人成为管理员
    /// </summary>
    public class IrEvent210 : IIrEvent
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;

        public IrEvent210(
            IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
        }

        public int IrEventCode { get; } = 210;

        public void Handle(IrEventInput eventFunInput)
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
