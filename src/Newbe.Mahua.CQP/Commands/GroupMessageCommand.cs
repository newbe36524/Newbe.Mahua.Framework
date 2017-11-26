using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupMessageCommandHandler : ICommandHandler<GroupMessageCommand>
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public GroupMessageCommandHandler(IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public void Handle(GroupMessageCommand command)
        {
            _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
            {
                SendTime = command.SendTime,
                FromAnonymous = command.FromAnonymous,
                FromGroup = command.GroupNum.ToString(),
                FromQq = command.FromQq.ToString(),
                Message = command.Message,
            }));
        }
    }

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
    }
}
