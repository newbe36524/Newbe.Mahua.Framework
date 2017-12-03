namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///好友状态改变  10=在线 30=离开  50=忙碌 60=Q我  70=勿扰 201=离线或隐身
    ///</summary>
    public class EventFunHandler1002 : IEventFunHandler
    {
        public int EventFun { get; } = 1002;

        public void Handle(EventFunInput eventFunInput)
        {
            //todo there is no mahua event
        }
    }
}
