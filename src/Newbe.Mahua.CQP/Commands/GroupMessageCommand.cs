using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class GroupMessageCommand : CqpCommand
    {
        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public long GroupNum { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public string FromAnonymous { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public long MessageId { get; set; }
    }

    internal class GroupMessageCommandHandler : ICommandHandler<GroupMessageCommand>
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public GroupMessageCommandHandler(IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public void Handle(GroupMessageCommand message)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
            {
                SendTime = message.SendTime,
                FromAnonymous = message.FromAnonymous,
                FromGroup = message.GroupNum.ToString(),
                FromQq = message.FromQq.ToString(),
                Message = message.Message,
                MessageId = message.MessageId,
            }));
        }
    }
}
