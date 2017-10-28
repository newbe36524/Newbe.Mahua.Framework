using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupMemberIncreasedCommandHandler : ICommandHandler<GroupMemberIncreasedCommand>
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberIncreasedMahuaEvent> _groupMemberIncreasedMahuaEvents;

        public GroupMemberIncreasedCommandHandler(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberIncreasedMahuaEvent> groupMemberIncreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberIncreasedMahuaEvents = groupMemberIncreasedMahuaEvents;
        }

        public void Handle(GroupMemberIncreasedCommand command)
        {
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = command.SendTime,
                FromGroup = command.FromGroup.ToString(),
                JoinedOrLeftQq = command.ToQq.ToString(),
                GroupMemberChangedType = GroupMemberChangedType.Increased
            }));
            _groupMemberIncreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberIncreased(new GroupMemberIncreasedContext
                {
                    SendTime = command.SendTime,
                    FromGroup = command.FromGroup.ToString(),
                    JoinedQq = command.ToQq.ToString(),
                    InvitatorOrAdmin = command.FromQq.ToString(),
                    GroupMemberIncreasedReason = command.GroupMemberIncreasedReason
                }));
        }
    }

    [DataContract]
    public class GroupMemberIncreasedCommand : CqpCommand
    {
        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public GroupMemberIncreasedReason GroupMemberIncreasedReason { get; set; }

        [DataMember]
        public long FromGroup { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public long ToQq { get; set; }
    }
}
