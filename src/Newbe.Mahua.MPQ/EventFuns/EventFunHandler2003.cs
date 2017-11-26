using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///我被邀请加入群
    ///</summary>
    public class EventFunHandler2003 : IEventFunHandler
    {
        public int EventFun { get; } = 2003;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}