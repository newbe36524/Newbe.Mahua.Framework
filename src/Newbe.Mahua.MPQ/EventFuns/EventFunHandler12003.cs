namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 插件被点击 点击方式参考子类型.  1=左键单击 2=右键单击 3=左键双击
    /// </summary>
    public class EventFunHandler12003 : IEventFunHandler
    {
        public int EventFun { get; } = 12003;

        public void Handle(EventFunInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
