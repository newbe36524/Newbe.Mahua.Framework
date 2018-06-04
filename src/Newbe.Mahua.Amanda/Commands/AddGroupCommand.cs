using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
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

    internal class AddGroupCommandHandler : ICommandHandler<AddGroupCommand>
    {
        private readonly IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> _groupJoiningRequestReceivedMahuaEvents;

        private readonly IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent>
            _groupJoiningInvitationReceivedMahuaEvents;

        public AddGroupCommandHandler(
            IEnumerable<IGroupJoiningRequestReceivedMahuaEvent> groupJoiningRequestReceivedMahuaEvents,
            IEnumerable<IGroupJoiningInvitationReceivedMahuaEvent> groupJoiningInvitationReceivedMahuaEvents)
        {
            _groupJoiningRequestReceivedMahuaEvents = groupJoiningRequestReceivedMahuaEvents;
            _groupJoiningInvitationReceivedMahuaEvents = groupJoiningInvitationReceivedMahuaEvents;
        }

        public void Handle(AddGroupCommand message)
        {
            const string AddGroup主动加群 = "1";
            const string AddGroup被邀请进群 = "2";
            const string AddGroup机器人被邀请入群 = "3";
            switch (message.Type)
            {
                case AddGroup主动加群:
                    _groupJoiningRequestReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                        new GroupJoiningRequestReceivedContext
                        {
                            Message = message.MoreMsg,

                            // 主动申请入群的申请者
                            FromQq = message.Fromqq,
                            SendTime = DateTime.Now,
                            GroupJoiningRequestId = message.Seq,
                            ToGroup = message.Fromgroup
                        }));
                    break;
                case AddGroup被邀请进群:
                    break;
                case AddGroup机器人被邀请入群:
                    _groupJoiningInvitationReceivedMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(
                        new GroupJoiningRequestReceivedContext
                        {
                            Message = message.MoreMsg,

                            // 机器人被邀请时，这就是邀请者
                            FromQq = message.InvatorQq,
                            ToGroup = message.Fromgroup,
                            SendTime = DateTime.Now,
                            GroupJoiningRequestId = message.Seq
                        }));
                    break;
                default: throw new ArgumentOutOfRangeException(message.Type);
            }
        }
    }
}
