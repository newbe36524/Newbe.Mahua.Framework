using Newbe.Mahua.Commands;
using Newbe.Mahua.MPQ.NativeApi;
using System;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class EventFunCommandHandler : ICommandHandler<EventFunCommand, EventFunCommandResult>
    {
        private readonly IQqContainer _qqContainer;

        public EventFunCommandHandler(IQqContainer qqContainer)
        {
            _qqContainer = qqContainer;
        }

        public EventFunCommandResult Handle(EventFunCommand message)
        {
            throw new NotImplementedException();
        }
    }

    internal class EventFunCommand : MpqCommand<EventFunCommandResult>
    {
        public long ReceiverQq { get; set; }
        public int EventType { get; set; }
        public int EventAdditionType { get; set; }
        public long FromNum { get; set; }
        public string EventOperator { get; set; }
        public string Triggee { get; set; }
        public string Message { get; set; }
        public string RawMessage { get; set; }
    }

    internal class EventFunCommandResult : MpqCommandResult
    {
        public int ResultCode { get; set; }
    }
}
