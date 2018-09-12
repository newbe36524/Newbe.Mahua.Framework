using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 讨论组信息
    /// </summary>
    public class IR_Event3 : IIR_Event
    {
        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _discussMessageReceivedMahuaEvents;

        public IR_Event3(
            IEnumerable<IDiscussMessageReceivedMahuaEvent> discussMessageReceivedMahuaEvents)
        {
            _discussMessageReceivedMahuaEvents = discussMessageReceivedMahuaEvents;
        }

        public int IR_Event { get; } = 3;

        public void Handle(IR_EventInput eventFunInput)
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
