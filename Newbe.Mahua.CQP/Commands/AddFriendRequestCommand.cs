using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class AddFriendRequestCommandHandler : CommandHandlerBase<AddFriendRequestCommand>
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingFriendRequestMahuaEvents;

        public AddFriendRequestCommandHandler(
            IEnumerable<IFriendAddingRequestMahuaEvent> addingFriendRequestMahuaEvents)
        {
            _addingFriendRequestMahuaEvents = addingFriendRequestMahuaEvents;
        }

        protected override void HandleCore(AddFriendRequestCommand command)
        {
            _addingFriendRequestMahuaEvents.Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
            {
                SendTime = command.SendTime,
                FromQq = command.FromQq.ToString(),
                Message = command.Message,
            }));
        }
    }

    [Serializable]
    internal class AddFriendRequestCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}