using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class BecomeFriendsCommandHandler : CommandHandlerBase<BecomeFriendsCommand>
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddedMahuaEvents;

        public BecomeFriendsCommandHandler(IEnumerable<IFriendAddedMahuaEvent> friendAddedMahuaEvents)
        {
            _friendAddedMahuaEvents = friendAddedMahuaEvents;
        }

        protected override void HandleCore(BecomeFriendsCommand command)
        {
            _friendAddedMahuaEvents.Handle(x => x.ProcessFriendsAdded(new FriendAddedMahuaEventContext
            {
                SendTime = DateTime.Now,
                FromQq = command.Fromqq,
            }));
        }
    }

    [Serializable]
    internal class BecomeFriendsCommand : AmandaCommand
    {
        public string Fromqq { get; set; }
    }
}