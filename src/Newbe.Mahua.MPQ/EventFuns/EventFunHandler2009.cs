using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人成为管理员
    ///</summary>
    public class EventFunHandler2009 : IEventFunHandler
    {
        public int EventFun { get; } = 2009;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}