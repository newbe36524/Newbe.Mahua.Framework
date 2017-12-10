using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class GroupMemberDecreasedCommand : CqpCommand
    {
        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }

        [DataMember]
        public long FromGroup { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public long ToQq { get; set; }
    }

    internal class GroupMemberDecreasedCommandHandler : ICommandHandler<GroupMemberDecreasedCommand>
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberDecreasedMahuaEvent> _groupMemberDecreasedMahuaEvents;

        public GroupMemberDecreasedCommandHandler(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberDecreasedMahuaEvent> groupMemberDecreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberDecreasedMahuaEvents = groupMemberDecreasedMahuaEvents;
        }

        public void Handle(GroupMemberDecreasedCommand message)
        {
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = message.SendTime,
                FromGroup = message.FromGroup.ToString(),
                JoinedOrLeftQq = message.ToQq.ToString(),
                GroupMemberChangedType = GroupMemberChangedType.Decreased
            }));
            _groupMemberDecreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberDecreased(new GroupMemberDecreasedContext
                {
                    SendTime = message.SendTime,
                    FromGroup = message.FromGroup.ToString(),
                    ToQq = message.ToQq.ToString(),
                    FromQq = message.FromQq.ToString(),
                    GroupMemberDecreasedReason = message.GroupMemberDecreasedReason
                }));
        }
    }
}
