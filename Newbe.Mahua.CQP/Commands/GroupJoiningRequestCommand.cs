using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupJoiningRequestCommandHandler : CommandHandlerBase<GroupJoiningRequestCommand>
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        public GroupJoiningRequestCommandHandler(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
        }

        protected override void HandleCore(GroupJoiningRequestCommand command)
        {
            _groupJoiningRequestReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                new GroupJoiningRequestReceivedContext
                {
                    GroupJoiningRequestId = command.GroupJoiningRequestId,
                    SendTime = command.SendTime,
                    FromQq = command.FromQq,
                    ToGroup = command.ToGroup,
                    Message = command.Message,
                }));
        }
    }

    [Serializable]
    internal class GroupJoiningRequestCommand : CqpCommand
    {
        public string GroupJoiningRequestId { get; set; }
        public DateTime SendTime { get; set; }
        public long ToGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}