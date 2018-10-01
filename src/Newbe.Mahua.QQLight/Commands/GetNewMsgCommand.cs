using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    public enum FromMessageType
    {
        Unknown,
        好友消息,
        群消息,
        群临时消息,
        讨论组消息,
        讨论组临时消息,
    }

    [DataContract]
    public class GetNewMsgCommand : QqLightCommand
    {
        [DataMember]
        public FromMessageType Type { get; set; }

        [DataMember]
        public string Fromgroup { get; set; }

        [DataMember]
        public string Fromqq { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public long MessageId { get; set; }
    }

    internal class GetNewMsgCommandHandler : ICommandHandler<GetNewMsgCommand>
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

        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _discussMessageReceivedMahuaEvents;

        public GetNewMsgCommandHandler(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent> privateMessageFromFriendReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromOnlineReceivedMahuaEvent> privateMessageFromOnlineReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent> privateMessageFromGroupReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent> privateMessageFromDiscussGroupReceivedMahuaEvents,
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents,
            IEnumerable<IDiscussMessageReceivedMahuaEvent> discussMessageReceivedMahuaEvents)
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromFriendReceivedMahuaEvents = privateMessageFromFriendReceivedMahuaEvents;
            _privateMessageFromOnlineReceivedMahuaEvents = privateMessageFromOnlineReceivedMahuaEvents;
            _privateMessageFromGroupReceivedMahuaEvents = privateMessageFromGroupReceivedMahuaEvents;
            _privateMessageFromDiscussGroupReceivedMahuaEvents = privateMessageFromDiscussGroupReceivedMahuaEvents;
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
            _discussMessageReceivedMahuaEvents = discussMessageReceivedMahuaEvents;
        }

        public void Handle(GetNewMsgCommand message)
        {
            var sendTime = DateTime.Now;
            var commandFromqq = message.Fromqq;
            if (message.Type == FromMessageType.Unknown)
            {
                // todo
                return;
            }
            if (message.Type == FromMessageType.群消息)
            {
                _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
                {
                    Message = message.Message,
                    FromQq = commandFromqq,
                    FromGroup = message.Fromgroup,
                    SendTime = sendTime,
                    MessageId = message.MessageId,
                }));
                return;
            }
            if (message.Type == FromMessageType.讨论组消息)
            {
                _discussMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessageReceived(
                    new DiscussMessageReceivedMahuaEventContext
                    {
                        Message = message.Message,
                        FromQq = commandFromqq,
                        FromDiscuss = message.Fromgroup,
                        SendTime = sendTime,
                        MessageId = message.MessageId,
                    }));
                return;
            }
            var type = ConvertType(message.Type);
            _privateMessageReceivedMahuaEvents.Handle(x =>
            {
                x.ProcessPrivateMessage(new PrivateMessageReceivedContext
                {
                    SendTime = sendTime,
                    FromQq = commandFromqq,
                    Message = message.Message,
                    PrivateMessageFromType = type,
                    MessageId = message.MessageId,
                });
            });
            switch (type)
            {
                case PrivateMessageFromType.Unknown:
                    break;
                case PrivateMessageFromType.Friend:
                    _privateMessageFromFriendReceivedMahuaEvents.Handle(x => x.ProcessFriendMessage(
                        new PrivateMessageFromFriendReceivedContext
                        {
                            SendTime = sendTime,
                            FromQq = commandFromqq,
                            Message = message.Message,
                            MessageId = message.MessageId,
                        }));
                    break;
                case PrivateMessageFromType.Online:
                    _privateMessageFromOnlineReceivedMahuaEvents.Handle(x => x.ProcessOnlineMessage(
                        new PrivateMessageFromOnlineReceivedContext
                        {
                            SendTime = sendTime,
                            FromQq = commandFromqq,
                            Message = message.Message,
                            MessageId = message.MessageId,
                        }));
                    break;
                case PrivateMessageFromType.Group:
                    _privateMessageFromGroupReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(
                        new PrivateMessageFromGroupReceivedContext
                        {
                            SendTime = sendTime,
                            Message = message.Message,
                            FromGroup = message.Fromgroup,
                            FromQq = commandFromqq,
                            MessageId = message.MessageId,
                        }));
                    break;
                case PrivateMessageFromType.DiscussGroup:
                    _privateMessageFromDiscussGroupReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessage(
                        new PrivateMessageFromDiscussReceivedContext
                        {
                            SendTime = sendTime,
                            Message = message.Message,
                            FromDiscuss = message.Fromgroup,
                            FromQq = commandFromqq,
                            MessageId = message.MessageId,
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(message));
            }
        }

        private static PrivateMessageFromType ConvertType(FromMessageType source)
        {
            switch (source)
            {
                case FromMessageType.好友消息:
                    return PrivateMessageFromType.Friend;
                case FromMessageType.群临时消息:
                    return PrivateMessageFromType.Group;
                case FromMessageType.讨论组临时消息:
                    return PrivateMessageFromType.DiscussGroup;
                case FromMessageType.Unknown:
                case FromMessageType.讨论组消息:
                case FromMessageType.群消息:
                    return PrivateMessageFromType.Unknown;
                default:
                    throw new ArgumentOutOfRangeException(nameof(source), source, null);
            }
        }
    }
}
