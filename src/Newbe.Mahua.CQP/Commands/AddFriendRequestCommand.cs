using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class AddFriendRequestCommand : CqpCommand
    {
        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    internal class AddFriendRequestCommandHandler : ICommandHandler<AddFriendRequestCommand>
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingFriendRequestMahuaEvents;

        public AddFriendRequestCommandHandler(
            IEnumerable<IFriendAddingRequestMahuaEvent> addingFriendRequestMahuaEvents)
        {
            _addingFriendRequestMahuaEvents = addingFriendRequestMahuaEvents;
        }

        public void Handle(AddFriendRequestCommand message)
        {
            _addingFriendRequestMahuaEvents.Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
            {
                SendTime = message.SendTime,
                FromQq = message.FromQq.ToString(),
                Message = message.Message,
            }));
        }
    }
}
