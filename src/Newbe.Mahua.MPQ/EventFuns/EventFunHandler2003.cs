using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 我被邀请加入群
    /// </summary>
    public class EventFunHandler2003 : IEventFunHandler
    {
        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> _groupJoiningInvitationReceivedMahuaEvents;

        public EventFunHandler2003(
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        public int EventFun { get; } = 2003;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupJoiningInvitationReceivedMahuaEvents
                .Handle(x => x.ProcessJoinGroupRequest(new GroupJoiningRequestReceivedContext
                {
                    SendTime = Clock.Now,
                    Message = eventFunInput.Message,
                    FromQq = eventFunInput.EventOperator,
                    ToGroup = eventFunInput.FromNum,

                    // todo GroupJoiningRequestId
                    // GroupJoiningRequestId =
                }));
        }
    }
}
