using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MPQ.Messages.CancelMessage;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    ///     群信息
    /// </summary>
    public class EventFun2 : IEventFun
    {
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        public EventFun2(
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents)
        {
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
        }

        public int EventFun { get; } = 2;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupMessageReceivedMahuaEvents
                .Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    FromQq = eventFunInput.EventOperator,

                    // todo there is no FromAnonymous
                    // FromAnonymous = e,
                    MessageCancelToken = MpqCancelMessageToken.EmptyActionToken
                }));
        }
    }
}