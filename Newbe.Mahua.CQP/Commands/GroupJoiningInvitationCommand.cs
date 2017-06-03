using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupJoiningInvitationCommandHandler : CommandHandlerBase<GroupJoiningInvitationCommand>
    {
        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent>
            _groupJoiningInvitationReceivedMahuaEvents;

        public GroupJoiningInvitationCommandHandler(
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        protected override void HandleCore(GroupJoiningInvitationCommand command)
        {
            _groupJoiningInvitationReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                new GroupJoiningRequestReceivedContext
                {
                    GroupJoiningRequestId = command.GroupJoiningInvitationId,
                    SendTime = command.SendTime,
                    FromQq = command.FromQq,
                    ToGroup = command.ToGroup,
                    Message = command.Message,
                }));
        }
    }

    [Serializable]
    internal class GroupJoiningInvitationCommand : CqpCommand
    {
        public string GroupJoiningInvitationId { get; set; }
        public DateTime SendTime { get; set; }
        public long ToGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}