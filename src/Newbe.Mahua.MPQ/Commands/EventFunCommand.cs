using Newbe.Mahua.Commands;
using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class EventFunCommandHandler : ICommandHandler<EventFunCommand, EventFunCommandResult>
    {
        private readonly IQqSession _qqSession;

        public EventFunCommandHandler(IQqSession qqSession)
        {
            _qqSession = qqSession;
        }

        public EventFunCommandResult Handle(EventFunCommand message)
        {
            _qqSession.CurrentQq = message.ReceiverQq;
            throw new NotImplementedException();
        }
    }

    [DataContract]
    public class EventFunCommand : MpqCommand<EventFunCommandResult>
    {
        [DataMember]
        public string ReceiverQq { get; set; }

        [DataMember]
        public int EventType { get; set; }

        [DataMember]
        public int EventAdditionType { get; set; }

        [DataMember]
        public string FromNum { get; set; }

        [DataMember]
        public string EventOperator { get; set; }

        [DataMember]
        public string Triggee { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string RawMessage { get; set; }
    }

    [DataContract]
    public class EventFunCommandResult : MpqCommandResult
    {
        [DataMember]
        public int Result { get; set; }
    }
}
