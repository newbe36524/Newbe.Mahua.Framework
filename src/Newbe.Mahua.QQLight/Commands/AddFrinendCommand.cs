using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class AddFrinendCommand : QqLightCommand
    {
        [DataMember]
        public string Fromqq { get; set; }

        [DataMember]
        public string Reason { get; set; }
    }

    internal class AddFrinendCommandHandler : ICommandHandler<AddFrinendCommand>
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingRequestMahuaEvents;

        public AddFrinendCommandHandler(IEnumerable<IFriendAddingRequestMahuaEvent> addingRequestMahuaEvents)
        {
            _addingRequestMahuaEvents = addingRequestMahuaEvents;
        }

        public void Handle(AddFrinendCommand message)
        {
            _addingRequestMahuaEvents.Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
            {
                Message = message.Reason,
                FromQq = message.Fromqq,
                SendTime = DateTime.Now,

                // todo QqLight 不知道是否需要这个参数
                // AddingFriendRequestId =
            }));
        }
    }
}
