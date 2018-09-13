using Autofac.Features.Indexed;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Logging;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace Newbe.Mahua.CleverQQ.Commands
{
    public class EventFunCommandHandler : ICommandHandler<EventFunCommand, EventFunCommandResult>
    {
        private static readonly ILog Logger = LogProvider.For<EventFunCommandHandler>();
        private readonly IRobotSessionContext _robotSessionContext;
        private readonly IIR_EventOutput _eventFunOutput;
        private readonly IIndex<int, IIR_Event> _eventFuncHandlers;

        public EventFunCommandHandler(
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput,
            IIndex<int, IIR_Event> eventFuncHandlers)
        {
            _robotSessionContext = robotSessionContext;
            _eventFunOutput = eventFunOutput;
            _eventFuncHandlers = eventFuncHandlers;
        }

        public EventFunCommandResult Handle(EventFunCommand message)
        {
            _robotSessionContext.CurrentQq = message.ReceiverQq;
            if (_eventFuncHandlers.TryGetValue(message.EventType, out var handler))
            {
                handler.Handle(new IR_EventInput
                {
                    EventOperator = message.EventOperator,
                    RawMessage = message.RawMessage,
                    Triggee = message.Triggee,
                    FromNum = message.FromNum,
                    EventAdditionType = message.EventAdditionType,
                    Message = message.Message,
                });
            }
            else
            {
                var js = new JavaScriptSerializer
                {
                    MaxJsonLength = int.MaxValue
                };
                Logger.Warn($"没有能够处理CleverQQ事件，事件内容为{js.Serialize(message)}");
            }

            return new EventFunCommandResult
            {
                Result = _eventFunOutput.Result,
            };
        }
    }

    [DataContract]
    public class EventFunCommand : CleverQQCommand<EventFunCommandResult>
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
    public class EventFunCommandResult : CleverQQCommandResult
    {
        [DataMember]
        public int Result { get; set; }
    }
}
