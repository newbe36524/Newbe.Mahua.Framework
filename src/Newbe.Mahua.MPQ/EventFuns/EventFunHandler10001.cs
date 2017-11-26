using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///框架即将重启
    ///</summary>
    public class EventFunHandler10001 : IEventFunHandler
    {
        public int EventFun { get; } = 10001;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}