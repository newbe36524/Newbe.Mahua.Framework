using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 某人被批准加入了群
    /// </summary>
    public class EventFunHandler2005 : IEventFunHandler
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberIncreasedMahuaEvent> _groupMemberIncreasedMahuaEvents;

        public EventFunHandler2005(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberIncreasedMahuaEvent> groupMemberIncreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberIncreasedMahuaEvents = groupMemberIncreasedMahuaEvents;
        }

        public int EventFun { get; } = 2005;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupMemberChangedMahuaEvents
                .Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
                {
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    GroupMemberChangedType = GroupMemberChangedType.Increased,
                    JoinedOrLeftQq = eventFunInput.Triggee
                }));
            _groupMemberIncreasedMahuaEvents
                .Handle(x => x.ProcessGroupMemberIncreased(new GroupMemberIncreasedContext
                {
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    GroupMemberIncreasedReason = GroupMemberIncreasedReason.AdminAllowed,
                    InvitatorOrAdmin = eventFunInput.EventOperator,
                    JoinedQq = eventFunInput.Triggee
                }));
        }
    }
}
