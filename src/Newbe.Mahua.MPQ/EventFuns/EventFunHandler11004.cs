namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// QQ长时间无响应或掉线
    /// </summary>
    public class EventFunHandler11004 : IEventFunHandler
    {
        public int EventFun { get; } = 11004;

        public void Handle(EventFunInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
