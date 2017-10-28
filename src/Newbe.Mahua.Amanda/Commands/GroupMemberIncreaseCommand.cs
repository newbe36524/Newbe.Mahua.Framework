using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GroupMemberIncreaseCommandHandler : ICommandHandler<GroupMemberIncreaseCommand>
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberIncreasedMahuaEvent> _groupMemberIncreasedMahuaEvents;

        public GroupMemberIncreaseCommandHandler(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberIncreasedMahuaEvent> groupMemberIncreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberIncreasedMahuaEvents = groupMemberIncreasedMahuaEvents;
        }


        private static GroupMemberIncreasedReason ConvertType(string type)
        {
            //1.主动入群  2.被xxx邀请入群
            switch (type)
            {
                case "1": return GroupMemberIncreasedReason.AdminAllowed;
                case "2": return GroupMemberIncreasedReason.GroupMemberInvitated;
                default: return GroupMemberIncreasedReason.Unknow;
            }
        }

        public void Handle(GroupMemberIncreaseCommand command)
        {
            var sendTime = DateTime.Now;

            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = sendTime,
                FromGroup = command.Fromgroup,
                JoinedOrLeftQq = command.Fromqq,
                GroupMemberChangedType = GroupMemberChangedType.Increased
            }));
            _groupMemberIncreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberIncreased(new GroupMemberIncreasedContext
                {
                    SendTime = sendTime,
                    FromGroup = command.Fromgroup,
                    JoinedQq = command.Fromqq,
                    InvitatorOrAdmin = command.OperatorQq,
                    GroupMemberIncreasedReason = ConvertType(command.Type)
                }));
        }
    }

    [DataContract]
    public class GroupMemberIncreaseCommand : AmandaCommand
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
