using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class BecomeFriendsCommand : QqLightCommand
    {
        [DataMember]
        public string Fromqq { get; set; }
    }

    internal class BecomeFriendsCommandHandler : ICommandHandler<BecomeFriendsCommand>
    {
        private readonly IEnumerable<IFriendAddedMahuaEvent> _friendAddedMahuaEvents;

        public BecomeFriendsCommandHandler(IEnumerable<IFriendAddedMahuaEvent> friendAddedMahuaEvents)
        {
            _friendAddedMahuaEvents = friendAddedMahuaEvents;
        }

        public void Handle(BecomeFriendsCommand message)
        {
            _friendAddedMahuaEvents.Handle(x => x.ProcessFriendsAdded(new FriendAddedMahuaEventContext
            {
                SendTime = DateTime.Now,
                FromQq = message.Fromqq,
            }));
        }
    }
}
