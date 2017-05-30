using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class FriendsAddedCommandHanlder : CommandHandlerBase<FriendsAddedCommand>
    {
        private readonly IEnumerable<IFriendAddingRequestReceivedMahuaEvent> _friendAddingRequestReceivedMahuaEvents;

        public FriendsAddedCommandHanlder(
            IEnumerable<IFriendAddingRequestReceivedMahuaEvent> friendAddingRequestReceivedMahuaEvents)
        {
            _friendAddingRequestReceivedMahuaEvents = friendAddingRequestReceivedMahuaEvents;
        }

        protected override void HandleCore(FriendsAddedCommand command)
        {
            _friendAddingRequestReceivedMahuaEvents.Handle(
                x => x.ProcessFriendsAdded(
                    new FriendAddingRequestReceivedMahuaEventContext
                    {
                        SendTime = command.SendTime,
                        FromQq = command.FromQq
                    }));
        }
    }

    internal class FriendsAddedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
    }
}