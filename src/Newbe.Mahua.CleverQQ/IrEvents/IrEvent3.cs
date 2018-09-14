using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 讨论组信息
    /// </summary>
    public class IrEvent3 : IIrEvent
    {
        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _discussMessageReceivedMahuaEvents;

        public IrEvent3(
            IEnumerable<IDiscussMessageReceivedMahuaEvent> discussMessageReceivedMahuaEvents)
        {
            _discussMessageReceivedMahuaEvents = discussMessageReceivedMahuaEvents;
        }

        public int IrEventCode { get; } = 3;

        public void Handle(IrEventInput eventFunInput)
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
