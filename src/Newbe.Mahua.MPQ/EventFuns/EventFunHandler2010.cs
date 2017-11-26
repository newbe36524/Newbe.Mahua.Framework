using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人被取消管理员
    ///</summary>
    public class EventFunHandler2010 : IEventFunHandler
    {
        public int EventFun { get; } = 2010;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}