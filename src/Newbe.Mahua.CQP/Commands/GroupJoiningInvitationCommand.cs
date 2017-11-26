using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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

    [DataContract]
    public class GroupJoiningInvitationCommand : CqpCommand
    {
        [DataMember]
        public string GroupJoiningInvitationId { get; set; }

        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public long ToGroup { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
