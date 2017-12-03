using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///讨论组信息
    ///</summary>
    public class EventFunHandler3 : IEventFunHandler
    {
        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _discussMessageReceivedMahuaEvents;

        public EventFunHandler3(
            IEnumerable<IDiscussMessageReceivedMahuaEvent> discussMessageReceivedMahuaEvents)
        {
            _discussMessageReceivedMahuaEvents = discussMessageReceivedMahuaEvents;
        }

        public int EventFun { get; } = 3;

        public void Handle(EventFunInput eventFunInput)
        {
            _discussMessageReceivedMahuaEvents
                .Handle(x =>
                    x.ProcessDiscussGroupMessageReceived(new DiscussMessageReceivedMahuaEventContext
                    {
                        SendTime = Clock.Now,
                        FromQq = eventFunInput.EventOperator,
                        FromDiscuss = eventFunInput.FromNum,
                        Message = eventFunInput.Message
                    }));
        }
    }
}
