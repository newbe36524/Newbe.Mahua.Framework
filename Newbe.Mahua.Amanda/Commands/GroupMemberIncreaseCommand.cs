using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GroupMemberIncreaseCommandHandler : CommandHandlerBase<GroupMemberIncreaseCommand>
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberIncreasedMahuaEvent> _groupMemberIncreasedMahuaEvents;

        public GroupMemberIncreaseCommandHandler(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberIncreasedMahuaEvent> groupMemberIncreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberIncreasedMahuaEvents = groupMemberIncreasedMahuaEvents;
        }


        private static GroupMemberIncreasedReason ConvertType(string type)
        {
            //1.主动入群  2.被xxx邀请入群
            switch (type)
            {
                case "1": return GroupMemberIncreasedReason.AdminAllowed;
                case "2": return GroupMemberIncreasedReason.GroupMemberInvitated;
                default: return GroupMemberIncreasedReason.Unknow;
            }
        }

        protected override void HandleCore(GroupMemberIncreaseCommand command)
        {
            var sendTime = DateTime.Now;

            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = sendTime,
                FromGroup = command.Fromgroup,
                JoinedOrLeftQq = command.Fromqq.ToString(),
                GroupMemberChangedType = GroupMemberChangedType.Increased
            }));
            _groupMemberIncreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberIncreased(new GroupMemberIncreasedContext
                {
                    SendTime = sendTime,
                    FromGroup = command.Fromgroup,
                    JoinedQq = command.Fromqq.ToString(),
                    InvitatorOrAdmin = command.OperatorQq.ToString(),
                    GroupMemberIncreasedReason = ConvertType(command.Type)
                }));
        }
    }

    [Serializable]
    internal class GroupMemberIncreaseCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string OperatorQq { get; set; }
    }
}