using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///好友信息
    ///</summary>
    public class EventFunHandler1 : IEventFunHandler
    {
        public int EventFun { get; } = 1;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}
