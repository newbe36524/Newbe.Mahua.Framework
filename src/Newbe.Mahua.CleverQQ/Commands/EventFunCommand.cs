using System;
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

        private static readonly JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer
        {
            MaxJsonLength = int.MaxValue
        };

        private readonly IRobotSessionContext _robotSessionContext;
        private readonly IIrEventOutput _eventFunOutput;
        private readonly IIndex<int, IIrEvent> _eventFuncHandlers;

        public EventFunCommandHandler(
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput,
            IIndex<int, IIrEvent> eventFuncHandlers)
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
                handler.Handle(new IrEventInput
                {
                    EventOperator = message.EventOperator,
                    RawMessage = message.RawMessage,
                    Triggee = message.Triggee,
                    FromNum = message.FromNum,
                    EventAdditionType = message.EventAdditionType,
                    Message = message.Message,
                    MessageId = message.MessageId,
                    MessageNum = message.MessageNum,
                });
            }
            else
            {
                object data = null;
                try
                {
                    data = JavaScriptSerializer.Serialize(message);
                }
                catch (Exception e)
                {
                    Logger.WarnException("尝试将Message序列化为 Json 时遇到了异常，将降级处理", e);
                    data = message;
                }

                Logger.Warn("没有能够处理CleverQQ事件，事件内容为{data}", data);
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
        [DataMember] public string ReceiverQq { get; set; }

        [DataMember] public int EventType { get; set; }

        [DataMember] public int EventAdditionType { get; set; }

        [DataMember] public string FromNum { get; set; }

        [DataMember] public string EventOperator { get; set; }

        [DataMember] public string Triggee { get; set; }

        [DataMember] public string Message { get; set; }

        [DataMember] public string RawMessage { get; set; }

        [DataMember] public long MessageId { get; set; }

        [DataMember] public long MessageNum { get; set; }
    }

    [DataContract]
    public class EventFunCommandResult : CleverQQCommandResult
    {
        [DataMember] public int Result { get; set; }
    }
}