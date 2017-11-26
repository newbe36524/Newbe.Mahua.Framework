using Autofac.Features.Indexed;
using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class EventFunCommandHandler : ICommandHandler<EventFunCommand, EventFunCommandResult>
    {
        private readonly IQqSession _qqSession;
        private readonly IEventFunOutput _eventFunOutput;
        private readonly IIndex<int, IEventFunHandler> _eventFuncHandlers;

        public EventFunCommandHandler(
            IQqSession qqSession,
            IEventFunOutput eventFunOutput,
            IIndex<int, IEventFunHandler> eventFuncHandlers
        )
        {
            _qqSession = qqSession;
            _eventFunOutput = eventFunOutput;
            _eventFuncHandlers = eventFuncHandlers;
        }

        public EventFunCommandResult Handle(EventFunCommand message)
        {
            _qqSession.CurrentQq = message.ReceiverQq;
            if (_eventFuncHandlers.TryGetValue(message.EventType, out var handler))
            {
                handler.Handle(new EventFunInput
                {
                    EventOperator = message.EventOperator,
                    RawMessage = message.RawMessage,
                    Triggee = message.Triggee,
                    FromNum = message.FromNum,
                    EventAdditionType = message.EventAdditionType,
                    Message = message.Message,
                });
            }
            //todo with else
            return new EventFunCommandResult
            {
                Result = _eventFunOutput.Result,
            };
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
