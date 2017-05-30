using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class GroupMessageCommandHandler : CommandHandlerBase<GroupMessageCommand>
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public GroupMessageCommandHandler(IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        protected override void HandleCore(GroupMessageCommand command)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(command.SendTime, command.GroupNum,
                command.FromQq, command.FromAnonymous, command.Message));
        }
    }

    internal class GroupMessageCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long GroupNum { get; set; }
        public long FromQq { get; set; }
        public string FromAnonymous { get; set; }
        public string Message { get; set; }
    }
}