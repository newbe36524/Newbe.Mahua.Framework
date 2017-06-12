using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class FriendsAddedCommandHandler : CommandHandlerBase<FriendsAddedCommand>
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddingRequestReceivedMahuaEvents;

        public FriendsAddedCommandHandler(
            IEnumerable<IFriendAddedMahuaEvent> friendAddingRequestReceivedMahuaEvents)
        {
            _friendAddingRequestReceivedMahuaEvents = friendAddingRequestReceivedMahuaEvents;
        }

        protected override void HandleCore(FriendsAddedCommand command)
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

    [Serializable]
    internal class FriendsAddedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
    }
}