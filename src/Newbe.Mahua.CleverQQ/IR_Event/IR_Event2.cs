using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 群信息
    /// </summary>
    public class IR_Event2 : IIR_Event
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public IR_Event2(
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public int IR_Event { get; } = 2;

        public void Handle(IR_EventInput eventFunInput)
        {
            _groupMessageReceivedMahuaEvents
                .Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    FromQq = eventFunInput.EventOperator,

                    // todo there is no FromAnonymous
                    // FromAnonymous = e
                }));
        }
    }
}
