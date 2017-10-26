using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupJoiningInvitationCommandHandler : ICommandHandler<GroupJoiningInvitationCommand>
    {
        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent>
            _groupJoiningInvitationReceivedMahuaEvents;

        public GroupJoiningInvitationCommandHandler(
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        public void Handle(GroupJoiningInvitationCommand command)
        {
            _groupJoiningInvitationReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                new GroupJoiningRequestReceivedContext
                {
                    GroupJoiningRequestId = command.GroupJoiningInvitationId,
                    SendTime = command.SendTime,
                    FromQq = command.FromQq.ToString(),
                    ToGroup = command.ToGroup.ToString(),
                    Message = command.Message,
                }));
        }
    }

    internal class GroupJoiningInvitationCommand : CqpCommand
    {
        public string GroupJoiningInvitationId { get; set; }
        public DateTime SendTime { get; set; }
        public long ToGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}
