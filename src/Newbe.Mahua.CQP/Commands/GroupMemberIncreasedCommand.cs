using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
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

        public void Handle(GroupMemberIncreasedCommand message)
        {
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = message.SendTime,
                FromGroup = message.FromGroup.ToString(),
                JoinedOrLeftQq = message.ToQq.ToString(),
                GroupMemberChangedType = GroupMemberChangedType.Increased
            }));
            _groupMemberIncreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberIncreased(new GroupMemberIncreasedContext
                {
                    SendTime = message.SendTime,
                    FromGroup = message.FromGroup.ToString(),
                    JoinedQq = message.ToQq.ToString(),
                    InvitatorOrAdmin = message.FromQq.ToString(),
                    GroupMemberIncreasedReason = message.GroupMemberIncreasedReason
                }));
        }
    }
}
