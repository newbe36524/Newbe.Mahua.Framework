using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Commands
{
    internal class FriendsAddedCommandHandler : ICommandHandler<FriendsAddedCommand>
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddingRequestReceivedMahuaEvents;

        public FriendsAddedCommandHandler(
            IEnumerable<IFriendAddedMahuaEvent> friendAddingRequestReceivedMahuaEvents)
        {
            _friendAddingRequestReceivedMahuaEvents = friendAddingRequestReceivedMahuaEvents;
        }
        public void Handle(FriendsAddedCommand command)
        {
            _friendAddingRequestReceivedMahuaEvents.Handle(
                x => x.ProcessFriendsAdded(
                    new FriendAddedMahuaEventContext
                    {
                        SendTime = command.SendTime,
                        FromQq = command.FromQq.ToString()
                    }));
        }
    }

    internal class FriendsAddedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
    }
}
