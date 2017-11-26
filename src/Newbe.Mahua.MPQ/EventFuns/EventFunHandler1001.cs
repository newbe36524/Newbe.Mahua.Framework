using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///被请求添加好友(设置了加好友理由、加好友需要填答案并由我审核)
    ///</summary>
    public class EventFunHandler1001 : IEventFunHandler
    {
        public int EventFun { get; } = 1001;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}