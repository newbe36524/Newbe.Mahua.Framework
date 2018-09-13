using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 某人申请加入群
    /// </summary>
    public class IR_Event213 : IIR_Event
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        public IR_Event213(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
        }

        public int IR_Event { get; } = 213;

        public void Handle(IR_EventInput eventFunInput)
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
