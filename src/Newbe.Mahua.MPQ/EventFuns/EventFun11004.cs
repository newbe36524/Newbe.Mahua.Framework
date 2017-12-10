namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// QQ长时间无响应或掉线
    /// </summary>
    public class EventFun11004 : IEventFun
    {
        public int EventFun { get; } = 11004;

        public void Handle(EventFunInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
