using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 讨论组临时会话信息
    /// </summary>
    public class IR_Event5 : IIR_Event
    {
        private readonly IEnumerable<IPrivateMessageReceivedMahuaEvent> _privateMessageReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent>
            _privateMessageFromDiscussReceivedMahuaEvents;

        public IR_Event5(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent> privateMessageFromDiscussReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromDiscussReceivedMahuaEvents = privateMessageFromDiscussReceivedMahuaEvents;
        }

        public int IR_Event { get; } = 5;

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
            _privateMessageFromDiscussReceivedMahuaEvents
                .Handle(x => x.ProcessDiscussGroupMessage(
                    new PrivateMessageFromDiscussReceivedContext
                    {
                        Message = eventFunInput.Message,
                        FromQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                        FromDiscuss = eventFunInput.FromNum,
                    }));
        }
    }
}
