using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 我被邀请加入群
    /// </summary>
    public class EventFun2003 : IEventFun
    {
        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> _groupJoiningInvitationReceivedMahuaEvents;

        public EventFun2003(
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
