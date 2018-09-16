using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class AdminChangeCommand : QqLightCommand
    {
        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public string Fromgroup { get; set; }

        [DataMember]
        public string Fromqq { get; set; }
    }

    internal class AdminChangeCommandHandler : ICommandHandler<AdminChangeCommand>
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;
        private readonly IEnumerable<IGroupAdminDisabledMahuaEvent> _groupAdminDisabledMahuaEvents;

        public AdminChangeCommandHandler(
            IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents,
            IEnumerable<IGroupAdminDisabledMahuaEvent> groupAdminDisabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
            _groupAdminDisabledMahuaEvents = groupAdminDisabledMahuaEvents;
        }

        public void Handle(AdminChangeCommand message)
        {
            var sendTime = DateTime.Now;
            var type = ConvertType(message.Type);
            _groupAdminChangedMahuaEvents.Handle(x => x.ProcessGroupAdminChange(new GroupAdminChangedContext
            {
                SendTime = sendTime,
                ToQq = message.Fromqq,
                FromGroup = message.Fromgroup,
                GroupAdminChangeType = type
            }));
            switch (type)
            {
                case GroupAdminChangeType.Enabled:
                    _groupAdminEnabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminEnabled(new GroupAdminEnabledContext
                        {
                            SendTime = sendTime,
                            FromGroup = message.Fromgroup,
                            ToQq = message.Fromqq,
                        }));
                    break;
                case GroupAdminChangeType.Disabled:
                    _groupAdminDisabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminDisabled(new GroupAdminDisabledContext
                        {
                            SendTime = sendTime,
                            FromGroup = message.Fromgroup,
                            ToQq = message.Fromqq,
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(message));
            }
        }

        private static GroupAdminChangeType ConvertType(int type)
        {
            // 1.xx被添加管理 2.xx被解除管理
            switch (type)
            {
                case 1: return GroupAdminChangeType.Enabled;
                case 2: return GroupAdminChangeType.Disabled;
                default: throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }
}
