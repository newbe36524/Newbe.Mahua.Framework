using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人申请加入群
    ///</summary>
    public class EventFunHandler2001 : IEventFunHandler
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        public EventFunHandler2001(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
        }

        public int EventFun { get; } = 2001;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupJoiningRequestReceivedMahuaEvents
                .Handle(x => x.ProcessJoinGroupRequest(new GroupJoiningRequestReceivedContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    FromQq = eventFunInput.EventOperator,
                    //todo with GroupJoiningRequestId
                    //GroupJoiningRequestId =
                    ToGroup = eventFunInput.FromNum
                }));
        }
    }
}
