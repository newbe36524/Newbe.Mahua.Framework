using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 我被邀请加入群
    /// </summary>
    public class IrEvent214 : IIrEvent
    {
        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> _groupJoiningInvitationReceivedMahuaEvents;

        public IrEvent214(
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        public int IrEventCode { get; } = 214;

        public void Handle(IrEventInput eventFunInput)
        {
            _groupJoiningInvitationReceivedMahuaEvents
                .Handle(x => x.ProcessGroupJoiningInvitation(new GroupJoiningInvitationReceivedContext
                {
                    SendTime = Clock.Now,
                    Message = eventFunInput.Message,
                    FromQq = eventFunInput.EventOperator,
                    ToGroup = eventFunInput.FromNum,

                    // todo GroupJoiningRequestId
                    //GroupJoiningInvitationId =
                }));
        }
    }
}
