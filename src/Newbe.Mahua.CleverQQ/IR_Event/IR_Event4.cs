using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    ///  群临时会话信息
    /// </summary>
    public class IR_Event4 : IIR_Event
    {
        private readonly IEnumerable<IPrivateMessageReceivedMahuaEvent> _privateMessageReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent>
            _privateMessageFromGroupReceivedMahuaEvents;

        public IR_Event4(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent> privateMessageFromGroupReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromGroupReceivedMahuaEvents = privateMessageFromGroupReceivedMahuaEvents;
        }

        public int IR_Event { get; } = 4;

        public void Handle(IR_EventInput eventFunInput)
        {
            _privateMessageReceivedMahuaEvents
                .Handle(x =>
                    x.ProcessPrivateMessage(new PrivateMessageReceivedContext
                    {
                        FromQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                        Message = eventFunInput.Message,
                        PrivateMessageFromType = PrivateMessageFromType.Group
                    }));
            _privateMessageFromGroupReceivedMahuaEvents
                .Handle(x => x.ProcessGroupMessage(
                    new PrivateMessageFromGroupReceivedContext
                    {
                        Message = eventFunInput.Message,
                        FromQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                        FromGroup = eventFunInput.FromNum,
                    }));
        }
    }
}
