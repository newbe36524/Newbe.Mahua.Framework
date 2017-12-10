using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class GroupAdminChangeCommand : CqpCommand
    {
        [DataMember]
        public GroupAdminChangeType GroupAdminChangeType { get; set; }

        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public long FromGroup { get; set; }

        [DataMember]
        public long ToQq { get; set; }
    }

    internal class GroupAdminChangeCommandHandler : ICommandHandler<GroupAdminChangeCommand>
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;
        private readonly IEnumerable<IGroupAdminDisabledMahuaEvent> _groupAdminDisabledMahuaEvents;

        public GroupAdminChangeCommandHandler(
            IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents,
            IEnumerable<IGroupAdminDisabledMahuaEvent> groupAdminDisabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
            _groupAdminDisabledMahuaEvents = groupAdminDisabledMahuaEvents;
        }

        public void Handle(GroupAdminChangeCommand message)
        {
            _groupAdminChangedMahuaEvents.Handle(x => x.ProcessGroupAdminChange(new GroupAdminChangedContext
            {
                SendTime = message.SendTime,
                ToQq = message.ToQq.ToString(),
                FromGroup = message.FromGroup.ToString(),
                GroupAdminChangeType = message.GroupAdminChangeType
            }));
            switch (message.GroupAdminChangeType)
            {
                case GroupAdminChangeType.Enabled:
                    _groupAdminEnabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminEnabled(new GroupAdminEnabledContext
                        {
                            SendTime = message.SendTime,
                            FromGroup = message.FromGroup.ToString(),
                            ToQq = message.ToQq.ToString()
                        }));
                    break;
                case GroupAdminChangeType.Disabled:
                    _groupAdminDisabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminDisabled(new GroupAdminDisabledContext
                        {
                            SendTime = message.SendTime,
                            FromGroup = message.FromGroup.ToString(),
                            ToQq = message.ToQq.ToString(),
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(message));
            }
        }
    }
}
