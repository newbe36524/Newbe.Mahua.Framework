using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///被单方面添加好友.(允许任何人添加好友、正确回答加好友问题的情况下会触发这个)
    ///</summary>
    public class EventFunHandler1000 : IEventFunHandler
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddedMahuaEvents;

        public EventFunHandler1000(
            IEnumerable<IFriendAddedMahuaEvent> friendAddedMahuaEvents)
        {
            _friendAddedMahuaEvents = friendAddedMahuaEvents;
        }

        public int EventFun { get; } = 1000;

        public void Handle(EventFunInput eventFunInput)
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
