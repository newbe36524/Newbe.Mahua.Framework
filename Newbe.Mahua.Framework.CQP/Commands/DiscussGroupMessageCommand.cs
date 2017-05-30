using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class DiscussGroupMessageCommandHandler : CommandHandlerBase<GroupMessageCommand>
    {
        private readonly IEnumerable<IDiscussGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public DiscussGroupMessageCommandHandler(
            IEnumerable<IDiscussGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        protected override void HandleCore(GroupMessageCommand command)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessage(command.SendTime,
                command.GroupNum,
                command.FromQq, command.Message));
        }
    }

    internal class DiscussGroupMessageCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long DiscussGroupNum { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}