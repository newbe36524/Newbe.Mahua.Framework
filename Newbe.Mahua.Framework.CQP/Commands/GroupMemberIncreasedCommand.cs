using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class GroupMemberIncreasedCommandHandler : CommandHandlerBase<GroupMemberIncreasedCommand>
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

        protected override void HandleCore(GroupMemberIncreasedCommand command)
        {
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(command.SendTime,
                GroupMemberChangedType.Increased,
                command.FromGroup, command.ToQq));
            _groupMemberIncreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberIncreased(command.SendTime, command.GroupMemberIncreasedReason,
                    command.FromGroup,
                    command.FromQq,
                    command.ToQq));
        }
    }

    internal class GroupMemberIncreasedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public GroupMemberIncreasedReason GroupMemberIncreasedReason { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public long ToQq { get; set; }
    }
}