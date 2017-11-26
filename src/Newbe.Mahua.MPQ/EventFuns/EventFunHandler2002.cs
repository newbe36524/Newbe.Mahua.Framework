using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人被邀请加入群
    ///</summary>
    public class EventFunHandler2002 : IEventFunHandler
    {
        public int EventFun { get; } = 2002;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}