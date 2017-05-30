using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.CQP.Commands
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
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(command.SendTime,
                GroupMemberChangedType.Decreased,
                command.FromGroup, command.ToQq));
            _groupMemberDecreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberDecreased(command.SendTime, command.GroupMemberDecreasedReason,
                    command.FromGroup,
                    command.FromQq,
                    command.ToQq));
        }
    }

    internal class GroupMemberDecreasedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public long ToQq { get; set; }
    }
}