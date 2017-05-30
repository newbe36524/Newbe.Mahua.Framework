using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class FriendsAddedCommandHanlder : CommandHandlerBase<FriendsAddedCommand>
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddingRequestReceivedMahuaEvents;

        public FriendsAddedCommandHanlder(
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
                        FromQq = command.FromQq
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