using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人被批准加入了群
    ///</summary>
    public class EventFunHandler2005 : IEventFunHandler
    {
        public int EventFun { get; } = 2005;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}