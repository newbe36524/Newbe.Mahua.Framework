using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///用户禁用本插件 无权拒绝
    ///</summary>
    public class EventFunHandler12002 : IEventFunHandler
    {
        public int EventFun { get; } = 12002;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}