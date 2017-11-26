using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    internal class AddFriendRequestCommandHandler : ICommandHandler<AddFriendRequestCommand>
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingFriendRequestMahuaEvents;

        public AddFriendRequestCommandHandler(
            IEnumerable<IFriendAddingRequestMahuaEvent> addingFriendRequestMahuaEvents)
        {
            _addingFriendRequestMahuaEvents = addingFriendRequestMahuaEvents;
        }

        public void Handle(AddFriendRequestCommand command)
        {
            _addingFriendRequestMahuaEvents.Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
            {
                SendTime = command.SendTime,
                FromQq = command.FromQq.ToString(),
                Message = command.Message,
            }));
        }
    }

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
}
