namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 好友离线文件接收
    /// </summary>
    public class IrEvent105 : IIrEvent
    {
        public int IrEventCode { get; } = 105;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
