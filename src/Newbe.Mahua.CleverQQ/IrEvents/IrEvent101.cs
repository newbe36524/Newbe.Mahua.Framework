using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 被请求添加好友(设置了加好友理由、加好友需要填答案并由我审核)
    /// </summary>
    public class IrEvent101 : IIrEvent
    {
        private readonly IEnumerable<IFriendAddingRequestMahuaEvent> _addingRequestMahuaEvents;

        public IrEvent101(
            IEnumerable<IFriendAddingRequestMahuaEvent> addingRequestMahuaEvents)
        {
            _addingRequestMahuaEvents = addingRequestMahuaEvents;
        }

        public int IrEventCode { get; } = 101;

        public void Handle(IrEventInput eventFunInput)
        {
            _addingRequestMahuaEvents
                .Handle(x => x.ProcessAddingFriendRequest(new FriendAddingRequestContext
                {
                    Message = eventFunInput.Message,
                    SendTime = Clock.Now,
                    FromQq = eventFunInput.FromNum,

                    // todo AddingFriendRequestId
                    // AddingFriendRequestId = eventFunInput.
                }));
        }
    }
}
