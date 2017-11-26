using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///临时会话信息
    ///</summary>
    public class EventFunHandler4 : IEventFunHandler
    {
        public int EventFun { get; } = 4;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}