namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 框架即将重启
    /// </summary>
    public class EventFun10001 : IEventFun
    {
        public int EventFun { get; } = 10001;

        public void Handle(EventFunInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
