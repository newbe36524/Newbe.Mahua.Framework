using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 好友信息
    /// </summary>
    public class EventFunHandler1 : IEventFunHandler
    {
        private readonly IEnumerable<IPrivateMessageReceivedMahuaEvent> _privateMessageReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent>
            _privateMessageFromFriendReceivedMahuaEvents;

        public EventFunHandler1(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent> privateMessageFromFriendReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromFriendReceivedMahuaEvents = privateMessageFromFriendReceivedMahuaEvents;
        }

        public int EventFun { get; } = 1;

        public void Handle(EventFunInput eventFunInput)
        {
            _privateMessageReceivedMahuaEvents
                .Handle(x =>
                    x.ProcessPrivateMessage(new PrivateMessageReceivedContext
                    {
                        FromQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                        Message = eventFunInput.Message,
                        PrivateMessageFromType = PrivateMessageFromType.Friend
                    }));
            _privateMessageFromFriendReceivedMahuaEvents
                .Handle(x => x.ProcessFriendMessage(
                    new PrivateMessageFromFriendReceivedContext
                    {
                        Message = eventFunInput.Message,
                        FromQq = eventFunInput.EventOperator,
                        SendTime = Clock.Now,
                    }));
        }
    }
}
