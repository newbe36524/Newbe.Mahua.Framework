using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class DiscussGroupMessageCommandHandler : CommandHandlerBase<DiscussGroupMessageCommand>
    {
        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public DiscussGroupMessageCommandHandler(
            IEnumerable<IDiscussMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        protected override void HandleCore(DiscussGroupMessageCommand command)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessageReceived(
                new DiscussMessageReceivedMahuaEventContext
                {
                    SendTime = command.SendTime,
                    FromQq = command.FromQq,
                    Message = command.Message,
                    FromDiscuss = command.DiscussGroupNum
                }));
        }
    }

    [Serializable]
    internal class DiscussGroupMessageCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long DiscussGroupNum { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}