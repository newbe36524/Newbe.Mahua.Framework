using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupMemberDecreasedCommandHandler : CommandHandlerBase<GroupMemberDecreasedCommand>
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

        protected override void HandleCore(GroupMemberDecreasedCommand command)
        {
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = command.SendTime,
                FromGroup = command.FromGroup.ToString(),
                JoinedOrLeftQq = command.ToQq.ToString(),
                GroupMemberChangedType = GroupMemberChangedType.Decreased
            }));
            _groupMemberDecreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberDecreased(new GroupMemberDecreasedContext
                {
                    SendTime = command.SendTime,
                    FromGroup = command.FromGroup.ToString(),
                    ToQq = command.ToQq.ToString(),
                    FromQq = command.FromQq.ToString(),
                    GroupMemberDecreasedReason = command.GroupMemberDecreasedReason
                }));
        }
    }

    [Serializable]
    internal class GroupMemberDecreasedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public long ToQq { get; set; }
    }
}