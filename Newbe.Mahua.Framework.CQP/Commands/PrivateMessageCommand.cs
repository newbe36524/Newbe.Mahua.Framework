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

        private readonly IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent>
            _privateMessageFromFriendReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromOnlineReceivedMahuaEvent>
            _privateMessageFromOnlineReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent>
            _privateMessageFromGroupReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent>
            _privateMessageFromDiscussGroupReceivedMahuaEvents;

        public PrivateMessageCommandHandler(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent> privateMessageFromFriendReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromOnlineReceivedMahuaEvent> privateMessageFromOnlineReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent> privateMessageFromGroupReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent>
                privateMessageFromDiscussGroupReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromFriendReceivedMahuaEvents = privateMessageFromFriendReceivedMahuaEvents;
            _privateMessageFromOnlineReceivedMahuaEvents = privateMessageFromOnlineReceivedMahuaEvents;
            _privateMessageFromGroupReceivedMahuaEvents = privateMessageFromGroupReceivedMahuaEvents;
            _privateMessageFromDiscussGroupReceivedMahuaEvents = privateMessageFromDiscussGroupReceivedMahuaEvents;
        }

        protected override void HandleCore(PrivateMessageCommand command)
        {
            _privateMessageReceivedMahuaEvents.Handle(x => x.ProcessPrivateMessage(new PrivateMessageReceivedContext
            {
                SendTime = command.SendTime,
                FromQq = command.FormNum,
                Message = command.Message,
                PrivateMessageFromType = command.PrivateMessageFromType,
            }));
            switch (command.PrivateMessageFromType)
            {
                case PrivateMessageFromType.Unknown:
                    break;
                case PrivateMessageFromType.Friend:
                    _privateMessageFromFriendReceivedMahuaEvents.Handle(x => x.ProcessFriendMessage(
                        new PrivateMessageFromFriendReceivedContext
                        {
                            SendTime = command.SendTime,
                            FromQq = command.FormNum,
                            Message = command.Message
                        }));
                    break;
                case PrivateMessageFromType.Online:
                    _privateMessageFromOnlineReceivedMahuaEvents.Handle(x => x.ProcessOnlineMessage(
                        new PrivateMessageFromOnlineReceivedContext
                        {
                            SendTime = command.SendTime,
                            FromQq = command.FormNum,
                            Message = command.Message,
                        }));
                    break;
                case PrivateMessageFromType.Group:
                    _privateMessageFromGroupReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(
                        new PrivateMessageFromGroupReceivedContext
                        {
                            SendTime = command.SendTime,
                            Message = command.Message,
                            FromGroup = command.FormNum,
                        }));
                    break;
                case PrivateMessageFromType.DiscussGroup:
                    _privateMessageFromDiscussGroupReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessage(
                        new PrivateMessageFromDiscussReceivedContext
                        {
                            SendTime = command.SendTime,
                            Message = command.Message,
                            FromDiscuss = command.FormNum,
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    [Serializable]
    internal class PrivateMessageCommand : CqpCommand
    {
        public PrivateMessageFromType PrivateMessageFromType { get; set; }
        public long FormNum { get; set; }
        public DateTime SendTime { get; set; }
        public string Message { get; set; }
    }
}