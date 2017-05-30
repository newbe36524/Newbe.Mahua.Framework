using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class AddFriendRequestCommandHandler : CommandHandlerBase<AddFriendRequestCommand>
    {
        private readonly IEnumerable<IAddingFriendRequestMahuaEvent> _addingFriendRequestMahuaEvents;

        public AddFriendRequestCommandHandler(
            IEnumerable<IAddingFriendRequestMahuaEvent> addingFriendRequestMahuaEvents)
        {
            _addingFriendRequestMahuaEvents = addingFriendRequestMahuaEvents;
        }

        protected override void HandleCore(AddFriendRequestCommand command)
        {
            _addingFriendRequestMahuaEvents.Handle(x => x.ProcessAddingFriendRequest(new AddingFriendRequestContext
            {
                SendTime = command.SendTime,
                FromQq = command.FromQq,
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