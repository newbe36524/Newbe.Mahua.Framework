using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 被单方面添加好友.(允许任何人添加好友、正确回答加好友问题的情况下会触发这个)
    /// </summary>
    public class IrEvent100 : IIrEvent
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddedMahuaEvents;

        public IrEvent100(
            IEnumerable<IFriendAddedMahuaEvent> friendAddedMahuaEvents)
        {
            _friendAddedMahuaEvents = friendAddedMahuaEvents;
        }

        public int IrEventCode { get; } = 100;

        public void Handle(IrEventInput eventFunInput)
        {
            _friendAddedMahuaEvents
                .Handle(x => x.ProcessFriendsAdded(new FriendAddedMahuaEventContext
                {
                    FromQq = eventFunInput.FromNum,
                    SendTime = Clock.Now,
                }));
        }
    }
}
