using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
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

    internal class GroupJoiningRequestCommandHandler : ICommandHandler<GroupJoiningRequestCommand>
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        public GroupJoiningRequestCommandHandler(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
        }

        public void Handle(GroupJoiningRequestCommand message)
        {
            _groupJoiningRequestReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                new GroupJoiningRequestReceivedContext
                {
                    GroupJoiningRequestId = message.GroupJoiningRequestId,
                    SendTime = message.SendTime,
                    FromQq = message.FromQq.ToString(),
                    ToGroup = message.ToGroup.ToString(),
                    Message = message.Message,
                }));
        }
    }
}
