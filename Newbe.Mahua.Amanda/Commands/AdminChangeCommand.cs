using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class AdminChangeCommandHandler : CommandHandlerBase<AdminChangeCommand>
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;
        private readonly IEnumerable<IGroupAdminDisabledMahuaEvent> _groupAdminDisabledMahuaEvents;

        public AdminChangeCommandHandler(IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents,
            IEnumerable<IGroupAdminDisabledMahuaEvent> groupAdminDisabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
            _groupAdminDisabledMahuaEvents = groupAdminDisabledMahuaEvents;
        }

        private static GroupAdminChangeType ConvertType(string type)
        {
            //1.xx被添加管理 2.xx被解除管理
            switch (type)
            {
                case "1": return GroupAdminChangeType.Enabled;
                case "2": return GroupAdminChangeType.Disabled;
                default: throw new ArgumentOutOfRangeException(nameof(type));
            }
        }

        protected override void HandleCore(AdminChangeCommand command)
        {
            var sendTime = DateTime.Now;
            var type = ConvertType(command.Type);
            _groupAdminChangedMahuaEvents.Handle(x => x.ProcessGroupAdminChange(new GroupAdminChangedContext
            {
                SendTime = sendTime,
                ToQq = command.Fromqq,
                FromGroup = command.Fromgroup,
                GroupAdminChangeType = type
            }));
            switch (type)
            {
                case GroupAdminChangeType.Enabled:
                    _groupAdminEnabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminEnabled(new GroupAdminEnabledContext
                        {
                            SendTime = sendTime,
                            FromGroup = command.Fromgroup,
                            ToQq = command.Fromqq,
                        }));
                    break;
                case GroupAdminChangeType.Disabled:
                    _groupAdminDisabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminDisabled(new GroupAdminDisabledContext
                        {
                            SendTime = sendTime,
                            FromGroup = command.Fromgroup,
                            ToQq = command.Fromqq,
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    [Serializable]
    internal class AdminChangeCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
    }
}