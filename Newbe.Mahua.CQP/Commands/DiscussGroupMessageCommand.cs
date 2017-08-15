using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Commands
{
    internal class DiscussGroupMessageCommandHandler : ICommandHandler<DiscussGroupMessageCommand>
    {
        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public DiscussGroupMessageCommandHandler(
            IEnumerable<IDiscussMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public void Handle(DiscussGroupMessageCommand command)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessageReceived(
                new DiscussMessageReceivedMahuaEventContext
                {
                    SendTime = command.SendTime,
                    FromQq = command.FromQq.ToString(),
                    Message = command.Message,
                    FromDiscuss = command.DiscussGroupNum.ToString()
                }));
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
