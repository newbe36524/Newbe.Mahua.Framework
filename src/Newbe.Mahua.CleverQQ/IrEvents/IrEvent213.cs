using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 某人申请加入群
    /// </summary>
    public class IrEvent213 : IIrEvent
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        public IrEvent213(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
        }

        public int IrEventCode { get; } = 213;

        public void Handle(IrEventInput eventFunInput)
        {
            _groupJoiningRequestReceivedMahuaEvents
                .Handle(x => x.ProcessJoinGroupRequest(new GroupJoiningRequestReceivedContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    FromQq = eventFunInput.EventOperator,

                    // todo with GroupJoiningRequestId
                    // GroupJoiningRequestId =
                    ToGroup = eventFunInput.FromNum
                }));
        }
    }
}
