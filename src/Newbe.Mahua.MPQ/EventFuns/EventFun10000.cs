namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 框架加载完成
    /// </summary>
    public class EventFun10000 : IEventFun
    {
        public int EventFun { get; } = 10000;

        public void Handle(EventFunInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
