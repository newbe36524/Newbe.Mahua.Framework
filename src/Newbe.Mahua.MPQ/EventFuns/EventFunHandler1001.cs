using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///被请求添加好友(设置了加好友理由、加好友需要填答案并由我审核)
    ///</summary>
    public class EventFunHandler1001 : IEventFunHandler
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingRequestMahuaEvents;

        public EventFunHandler1001(
            IEnumerable<IFriendAddingRequestMahuaEvent> addingRequestMahuaEvents)
        {
            _addingRequestMahuaEvents = addingRequestMahuaEvents;
        }

        public int EventFun { get; } = 1001;

        public void Handle(EventFunInput eventFunInput)
        {
            _addingRequestMahuaEvents
                .Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    FromQq = eventFunInput.FromNum,
                    //todo AddingFriendRequestId
                    //AddingFriendRequestId = eventFunInput.
                }));
        }
    }
}
