using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class DiscussGroupMessageCommand : CqpCommand
    {
        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public long DiscussGroupNum { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public long MessageId { get; set; }
    }

    internal class DiscussGroupMessageCommandHandler : ICommandHandler<DiscussGroupMessageCommand>
    {
        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public DiscussGroupMessageCommandHandler(
            IEnumerable<IDiscussMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public void Handle(DiscussGroupMessageCommand message)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessageReceived(
                new DiscussMessageReceivedMahuaEventContext
                {
                    SendTime = message.SendTime,
                    FromQq = message.FromQq.ToString(),
                    Message = message.Message,
                    FromDiscuss = message.DiscussGroupNum.ToString(),
                    MessageId = message.MessageId,
                }));
        }
    }
}
