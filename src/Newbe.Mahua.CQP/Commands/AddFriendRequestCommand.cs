using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

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

    internal class AddFriendRequestCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}
