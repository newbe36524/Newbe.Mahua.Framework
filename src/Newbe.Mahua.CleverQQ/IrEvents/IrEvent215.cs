using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 某人被邀请加入群
    /// </summary>
    public class IrEvent215 : IIrEvent
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberIncreasedMahuaEvent> _groupMemberIncreasedMahuaEvents;

        public IrEvent215(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberIncreasedMahuaEvent> groupMemberIncreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberIncreasedMahuaEvents = groupMemberIncreasedMahuaEvents;
        }

        public int IrEventCode { get; } = 215;

        public void Handle(IrEventInput eventFunInput)
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
                    GroupMemberIncreasedReason = GroupMemberIncreasedReason.GroupMemberInvitated,
                    InvitatorOrAdmin = eventFunInput.EventOperator,
                    JoinedQq = eventFunInput.Triggee
                }));
        }
    }
}
