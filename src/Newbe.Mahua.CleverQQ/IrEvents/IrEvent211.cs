using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 某人被取消管理员
    /// </summary>
    public class IrEvent211 : IIrEvent
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminDisabledMahuaEvent> _groupAdminDisabledMahuaEvents;

        public IrEvent211(
            IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminDisabledMahuaEvent> groupAdminDisabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminDisabledMahuaEvents = groupAdminDisabledMahuaEvents;
        }

        public int IrEventCode { get; } = 211;

        public void Handle(IrEventInput eventFunInput)
        {
            _groupAdminChangedMahuaEvents
                .Handle(x =>
                    x.ProcessGroupAdminChange(new GroupAdminChangedContext
                    {
                        FromGroup = eventFunInput.FromNum,
                        ToQq = eventFunInput.EventOperator,
                        GroupAdminChangeType = GroupAdminChangeType.Disabled,
                        SendTime = Clock.Now,
                    }));
            _groupAdminDisabledMahuaEvents
                .Handle(x =>
                    x.ProcessGroupAdminDisabled(new GroupAdminDisabledContext
                    {
                        FromGroup = eventFunInput.FromNum,
                        ToQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                    }));
        }
    }
}
