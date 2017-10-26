using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class BecomeFriendsCommandHandler : ICommandHandler<BecomeFriendsCommand>
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddedMahuaEvents;

        public BecomeFriendsCommandHandler(IEnumerable<IFriendAddedMahuaEvent> friendAddedMahuaEvents)
        {
            _friendAddedMahuaEvents = friendAddedMahuaEvents;
        }

        public void Handle(BecomeFriendsCommand command)
        {
            _friendAddedMahuaEvents.Handle(x => x.ProcessFriendsAdded(new FriendAddedMahuaEventContext
            {
                SendTime = DateTime.Now,
                FromQq = command.Fromqq,
            }));
        }
    }

    internal class BecomeFriendsCommand : AmandaCommand
    {
        public string Fromqq { get; set; }
    }
}
