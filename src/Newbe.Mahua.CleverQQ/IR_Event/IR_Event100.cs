using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 被单方面添加好友.(允许任何人添加好友、正确回答加好友问题的情况下会触发这个)
    /// </summary>
    public class IR_Event100 : IIR_Event
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddedMahuaEvents;

        public IR_Event100(
            IEnumerable<IFriendAddedMahuaEvent> friendAddedMahuaEvents)
        {
            _friendAddedMahuaEvents = friendAddedMahuaEvents;
        }

        public int IR_Event { get; } = 100;

        public void Handle(IR_EventInput eventFunInput)
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
