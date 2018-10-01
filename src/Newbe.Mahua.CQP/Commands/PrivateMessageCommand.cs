using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class PrivateMessageCommand : CqpCommand
    {
        [DataMember]
        public PrivateMessageFromType PrivateMessageFromType { get; set; }

        [DataMember]
        public long FormNum { get; set; }

        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public long MessageId { get; set; }
    }

    internal class PrivateMessageCommandHandler : ICommandHandler<PrivateMessageCommand>
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
            IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent> privateMessageFromDiscussGroupReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromFriendReceivedMahuaEvents = privateMessageFromFriendReceivedMahuaEvents;
            _privateMessageFromOnlineReceivedMahuaEvents = privateMessageFromOnlineReceivedMahuaEvents;
            _privateMessageFromGroupReceivedMahuaEvents = privateMessageFromGroupReceivedMahuaEvents;
            _privateMessageFromDiscussGroupReceivedMahuaEvents = privateMessageFromDiscussGroupReceivedMahuaEvents;
        }

        public void Handle(PrivateMessageCommand message)
        {
            _privateMessageReceivedMahuaEvents.Handle(x => x.ProcessPrivateMessage(new PrivateMessageReceivedContext
            {
                SendTime = message.SendTime,
                FromQq = message.FormNum.ToString(),
                Message = message.Message,
                PrivateMessageFromType = message.PrivateMessageFromType,
            }));
            switch (message.PrivateMessageFromType)
            {
                case PrivateMessageFromType.Unknown:
                    break;
                case PrivateMessageFromType.Friend:
                    _privateMessageFromFriendReceivedMahuaEvents.Handle(x => x.ProcessFriendMessage(
                        new PrivateMessageFromFriendReceivedContext
                        {
                            SendTime = message.SendTime,
                            FromQq = message.FormNum.ToString(),
                            Message = message.Message,
                            MessageId = message.MessageId,
                        }));
                    break;
                case PrivateMessageFromType.Online:
                    _privateMessageFromOnlineReceivedMahuaEvents.Handle(x => x.ProcessOnlineMessage(
                        new PrivateMessageFromOnlineReceivedContext
                        {
                            SendTime = message.SendTime,
                            FromQq = message.FormNum.ToString(),
                            Message = message.Message,
                            MessageId = message.MessageId,
                        }));
                    break;
                case PrivateMessageFromType.Group:
                    _privateMessageFromGroupReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(
                        new PrivateMessageFromGroupReceivedContext
                        {
                            SendTime = message.SendTime,
                            Message = message.Message,

                            // todo CQP 无法获取发送者的群
                            FromGroup = string.Empty,
                            FromQq = message.FormNum.ToString(),
                            MessageId = message.MessageId,
                        }));
                    break;
                case PrivateMessageFromType.DiscussGroup:
                    _privateMessageFromDiscussGroupReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessage(
                        new PrivateMessageFromDiscussReceivedContext
                        {
                            SendTime = message.SendTime,
                            Message = message.Message,

                            // todo CQP 无法获取发送者的讨论组信息
                            FromDiscuss = string.Empty,
                            FromQq = message.FormNum.ToString(),
                            MessageId = message.MessageId,
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(message));
            }
        }
    }
}
