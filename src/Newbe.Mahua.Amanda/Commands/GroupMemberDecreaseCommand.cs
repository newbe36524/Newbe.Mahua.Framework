using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GroupMemberDecreaseCommandHandler : ICommandHandler<GroupMemberDecreaseCommand>
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberDecreasedMahuaEvent> _groupMemberDecreasedMahuaEvents;

        public GroupMemberDecreaseCommandHandler(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberDecreasedMahuaEvent> groupMemberDecreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberDecreasedMahuaEvents = groupMemberDecreasedMahuaEvents;
        }

        private static GroupMemberDecreasedReason ConvertType(string type)
        {
            //1.主动退群  2.被xxx踢出群
            switch (type)
            {
                case "1": return GroupMemberDecreasedReason.Leavebyself;
                case "2": return GroupMemberDecreasedReason.Kicked;
                default: return GroupMemberDecreasedReason.Unknow;
            }
        }

        public void Handle(GroupMemberDecreaseCommand command)
        {
            var sendTime = DateTime.Now;
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = sendTime,
                FromGroup = command.Fromgroup,
                JoinedOrLeftQq = command.Fromqq,
                GroupMemberChangedType = GroupMemberChangedType.Decreased,
            }));
            _groupMemberDecreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberDecreased(new GroupMemberDecreasedContext
                {
                    SendTime = sendTime,
                    FromGroup = command.Fromgroup,
                    ToQq = command.Fromqq,
                    FromQq = command.OperatorQq,
                    GroupMemberDecreasedReason = ConvertType(command.Type)
                }));
        }
    }

    [DataContract]
    public class GroupMemberDecreaseCommand : AmandaCommand
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Fromgroup { get; set; }

        [DataMember]
        public string Fromqq { get; set; }

        [DataMember]
        public string OperatorQq { get; set; }
    }
}
