using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///对象被禁言
    ///</summary>
    public class EventFunHandler2014 : IEventFunHandler
    {
        public int EventFun { get; } = 2014;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}