using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 群信息
    /// </summary>
    public class IrEvent2 : IIrEvent
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public IrEvent2(
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public int IrEventCode { get; } = 2;

        public void Handle(IrEventInput eventFunInput)
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
