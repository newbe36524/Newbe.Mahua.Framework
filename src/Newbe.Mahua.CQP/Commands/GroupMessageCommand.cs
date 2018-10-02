using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newbe.Mahua.CQP.Messages.CancelMessage;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class GroupMessageCommand : CqpCommand
    {
        [DataMember] public DateTime SendTime { get; set; }

        [DataMember] public long GroupNum { get; set; }

        [DataMember] public long FromQq { get; set; }

        [DataMember] public string FromAnonymous { get; set; }

        [DataMember] public string Message { get; set; }

        [DataMember] public long MessageId { get; set; }
    }

    internal class GroupMessageCommandHandler : ICommandHandler<GroupMessageCommand>
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;
        private readonly CqpMessageCancelToken.Factory _factory;

        public GroupMessageCommandHandler(
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents,
            CqpMessageCancelToken.Factory factory)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
            _factory = factory;
        }

        public void Handle(GroupMessageCommand message)
        {
            var token = _factory(message.MessageId);
            _groupMessageReceivedMahuaEvents.Handle(x =>
            {
                x.ProcessGroupMessage(new GroupMessageReceivedContext
                {
                    SendTime = message.SendTime,
                    FromAnonymous = message.FromAnonymous,
                    FromGroup = message.GroupNum.ToString(),
                    FromQq = message.FromQq.ToString(),
                    Message = message.Message,
                    MessageCancelToken = token,
                });
            });
        }
    }
}