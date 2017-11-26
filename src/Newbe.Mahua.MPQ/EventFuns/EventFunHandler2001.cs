using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///某人申请加入群
    ///</summary>
    public class EventFunHandler2001 : IEventFunHandler
    {
        public int EventFun { get; } = 2001;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}