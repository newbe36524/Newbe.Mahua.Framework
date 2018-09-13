using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 我被邀请加入群
    /// </summary>
    public class IR_Event214 : IIR_Event
    {
        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> _groupJoiningInvitationReceivedMahuaEvents;

        public IR_Event214(
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        public int IR_Event { get; } = 214;

        public void Handle(IR_EventInput eventFunInput)
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
