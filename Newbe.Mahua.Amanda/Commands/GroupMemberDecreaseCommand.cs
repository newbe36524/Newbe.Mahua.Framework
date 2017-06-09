using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GroupMemberDecreaseCommandHandler : CommandHandlerBase<GroupMemberDecreaseCommand>
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberDecreasedMahuaEvent> _groupMemberDecreasedMahuaEvents;

        public GroupMemberDecreaseCommandHandler(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberDecreasedMahuaEvent> groupMemberDecreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberDecreasedMahuaEvents = groupMemberDecreasedMahuaEvents;
        }

        private static GroupMemberDecreasedReason ConvertType(string type)
        {
            //1.主动退群  2.被xxx踢出群
            switch (type)
            {
                case "1": return GroupMemberDecreasedReason.Leavebyself;
                case "2": return GroupMemberDecreasedReason.Kicked;
                default: return GroupMemberDecreasedReason.Unknow;
            }
        }

        protected override void HandleCore(GroupMemberDecreaseCommand command)
        {
            var sendTime = DateTime.Now;
            _groupMemberChangedMahuaEvents.Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
            {
                SendTime = sendTime,
                FromGroup = command.Fromgroup.ToString(),
                JoinedOrLeftQq = command.Fromqq.ToString(),
                GroupMemberChangedType = GroupMemberChangedType.Decreased,
            }));
            _groupMemberDecreasedMahuaEvents.Handle(
                x => x.ProcessGroupMemberDecreased(new GroupMemberDecreasedContext
                {
                    SendTime = sendTime,
                    FromGroup = command.Fromgroup.ToString(),
                    ToQq = command.Fromqq.ToString(),
                    FromQq = command.OperatorQq.ToString(),
                    GroupMemberDecreasedReason = ConvertType(command.Type)
                }));
        }
    }

    [Serializable]
    internal class GroupMemberDecreaseCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string OperatorQq { get; set; }
    }
}