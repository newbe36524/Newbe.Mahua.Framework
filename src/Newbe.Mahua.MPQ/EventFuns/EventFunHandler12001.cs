using System;

namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///用户启用本插件 返回20可拒绝启用 其他返回值均视为允许启用
    ///</summary>
    public class EventFunHandler12001 : IEventFunHandler
    {
        public int EventFun { get; } = 12001;

        public void Handle(EventFunInput eventFunInput)
        {
            throw new NotImplementedException();
        }
    }
}