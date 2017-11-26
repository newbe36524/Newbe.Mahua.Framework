using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class AddGroupCommandHandler : ICommandHandler<AddGroupCommand>
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent>
            _groupJoiningInvitationReceivedMahuaEvents;

        private const string AddGroup主动加群 = "1";
        private const string AddGroup被邀请进群 = "2";
        private const string AddGroup机器人被邀请入群 = "3";

        public AddGroupCommandHandler(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents,
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        public void Handle(AddGroupCommand command)
        {
            switch (command.Type)
            {
                case AddGroup主动加群:
                    _groupJoiningRequestReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                        new GroupJoiningRequestReceivedContext
                        {
                            Message = command.MoreMsg,
                            //主动申请入群的申请者
                            FromQq = command.Fromqq,
                            SendTime = DateTime.Now,
                            GroupJoiningRequestId = command.Seq,
                            ToGroup = command.Fromgroup
                        }));
                    break;
                case AddGroup被邀请进群:
                    break;
                case AddGroup机器人被邀请入群:
                    _groupJoiningInvitationReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                        new GroupJoiningRequestReceivedContext
                        {
                            Message = command.MoreMsg,
                            //机器人被邀请时，这就是邀请者
                            FromQq = command.InvatorQq,
                            ToGroup = command.Fromgroup,
                            SendTime = DateTime.Now,
                            GroupJoiningRequestId = command.Seq
                        }));
                    break;
                default: throw new ArgumentOutOfRangeException(command.Type);
            }
        }
    }

    [DataContract]
    public class AddGroupCommand : AmandaCommand
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Fromgroup { get; set; }

        [DataMember]
        public string Fromqq { get; set; }

        [DataMember]
        public string InvatorQq { get; set; }

        [DataMember]
        public string MoreMsg { get; set; }

        [DataMember]
        public string Seq { get; set; }
    }
}
