using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupJoiningRequestCommandHandler : ICommandHandler<GroupJoiningRequestCommand>
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        public GroupJoiningRequestCommandHandler(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
        }

        public void Handle(GroupJoiningRequestCommand command)
        {
            _groupJoiningRequestReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                new GroupJoiningRequestReceivedContext
                {
                    GroupJoiningRequestId = command.GroupJoiningRequestId,
                    SendTime = command.SendTime,
                    FromQq = command.FromQq.ToString(),
                    ToGroup = command.ToGroup.ToString(),
                    Message = command.Message,
                }));
        }
    }

    [DataContract]
    public class GroupJoiningRequestCommand : CqpCommand
    {
        [DataMember]
        public string GroupJoiningRequestId { get; set; }

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
