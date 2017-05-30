using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class PrivateMessageCommandHandler : CommandHandlerBase<PrivateMessageCommand>
    {
        private readonly IEnumerable<IPrivateMessageReceivedMahuaEvent> _privateMessageReceivedMahuaEvents;
        private readonly IEnumerable<IFriendMessageReceivedMahuaEvent> _friendMessageReceivedMahuaEvents;
        private readonly IEnumerable<IOnlineMessageReceivedMahuaEvent> _onlineMessageReceivedMahuaEvents;
        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;
        private readonly IEnumerable<IDiscussGroupMessageReceivedMahuaEvent> _discussGroupMessageReceivedMahuaEvents;

        public PrivateMessageCommandHandler(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IFriendMessageReceivedMahuaEvent> friendMessageReceivedMahuaEvents,
            IEnumerable<IOnlineMessageReceivedMahuaEvent> onlineMessageReceivedMahuaEvents,
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents,
            IEnumerable<IDiscussGroupMessageReceivedMahuaEvent> discussGroupMessageReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _friendMessageReceivedMahuaEvents = friendMessageReceivedMahuaEvents;
            _onlineMessageReceivedMahuaEvents = onlineMessageReceivedMahuaEvents;
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
            _discussGroupMessageReceivedMahuaEvents = discussGroupMessageReceivedMahuaEvents;
        }

        protected override void HandleCore(PrivateMessageCommand command)
        {
            _privateMessageReceivedMahuaEvents.Handle(x => x.ProcessPrivateMessage(command.PrivateMessageFromType,
                command.SendTime, command.FormNum, command.Message));
            switch (command.PrivateMessageFromType)
            {
                case PrivateMessageFromType.Unknown:
                    break;
                case PrivateMessageFromType.Friend:
                    _friendMessageReceivedMahuaEvents.Handle(x => x.ProcessFriendMessage(command.SendTime,
                        command.FormNum, command.Message));
                    break;
                case PrivateMessageFromType.Online:
                    _onlineMessageReceivedMahuaEvents.Handle(x => x.ProcessOnlineMessage(command.SendTime,
                        command.FormNum, command.Message));
                    break;
                case PrivateMessageFromType.Group:
                    _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(command.SendTime,
                        command.FormNum, command.Message));
                    break;
                case PrivateMessageFromType.DiscussGroup:
                    _discussGroupMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessage(command.SendTime,
                        command.FormNum, command.Message));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    internal class PrivateMessageCommand : CqpCommand
    {
        public PrivateMessageFromType PrivateMessageFromType { get; set; }
        public long FormNum { get; set; }
        public DateTime SendTime { get; set; }
        public string Message { get; set; }
    }
}