using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///群信息
    ///</summary>
    public class EventFunHandler2 : IEventFunHandler
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public EventFunHandler2(
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public int EventFun { get; } = 2;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupMessageReceivedMahuaEvents
                .Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    //todo there is no fromqq
                    //FromQq = eventFunInput.,
                    FromGroup = eventFunInput.FromNum
                }));
        }
    }
}
