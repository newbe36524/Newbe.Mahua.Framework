namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 本插件载入 返回20可拒绝加载 其他返回值均视为允许
    /// </summary>
    public class EventFunHandler12000 : IEventFunHandler
    {
        public int EventFun { get; } = 12000;

        public void Handle(EventFunInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
