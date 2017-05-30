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
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
            {
                SendTime = command.SendTime,
                FromAnonymous = command.FromAnonymous,
                FromGroup = command.GroupNum,
                FromQq = command.FromQq,
                Message = command.Message,
            }));
        }
    }

    [Serializable]
    internal class GroupMessageCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long GroupNum { get; set; }
        public long FromQq { get; set; }
        public string FromAnonymous { get; set; }
        public string Message { get; set; }
    }
}