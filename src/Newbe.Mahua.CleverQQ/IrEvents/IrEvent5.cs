using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 讨论组临时会话信息
    /// </summary>
    public class IrEvent5 : IIrEvent
    {
        private readonly IEnumerable<IPrivateMessageReceivedMahuaEvent> _privateMessageReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent>
            _privateMessageFromDiscussReceivedMahuaEvents;

        public IrEvent5(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent> privateMessageFromDiscussReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromDiscussReceivedMahuaEvents = privateMessageFromDiscussReceivedMahuaEvents;
        }

        public int IrEventCode { get; } = 5;

        public void Handle(IrEventInput eventFunInput)
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
