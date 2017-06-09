using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class AddFrinendCommandHandler : CommandHandlerBase<AddFrinendCommand>
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingRequestMahuaEvents;

        public AddFrinendCommandHandler(IEnumerable<IFriendAddingRequestMahuaEvent> addingRequestMahuaEvents)
        {
            _addingRequestMahuaEvents = addingRequestMahuaEvents;
        }

        protected override void HandleCore(AddFrinendCommand command)
        {
            _addingRequestMahuaEvents.Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
            {
                Message = command.Reason,
                FromQq = command.Fromqq,
                SendTime = DateTime.Now,
                //todo amanda 不知道是否需要这个参数
                //AddingFriendRequestId =
            }));
        }
    }

    [Serializable]
    internal class AddFrinendCommand : AmandaCommand
    {
        public string Fromqq { get; set; }
        public string Reason { get; set; }
    }
}