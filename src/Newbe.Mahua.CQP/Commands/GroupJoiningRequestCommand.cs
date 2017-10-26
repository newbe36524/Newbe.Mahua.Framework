using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

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

    internal class GroupJoiningRequestCommand : CqpCommand
    {
        public string GroupJoiningRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public long ToGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}
