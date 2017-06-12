using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.CQP.Commands
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

    [Serializable]
    internal class GroupMemberIncreasedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public GroupMemberIncreasedReason GroupMemberIncreasedReason { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public long ToQq { get; set; }
    }
}