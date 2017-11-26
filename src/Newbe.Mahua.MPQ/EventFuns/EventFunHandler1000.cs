using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///被单方面添加好友.(允许任何人添加好友、正确回答加好友问题的情况下会触发这个)
    ///</summary>
    public class EventFunHandler1000 : IEventFunHandler
    {
        public int EventFun { get; } = 1000;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}