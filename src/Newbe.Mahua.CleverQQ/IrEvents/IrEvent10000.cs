namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 框架加载完成
    /// </summary>
    public class IrEvent10000 : IIrEvent
    {
        public int IrEventCode { get; } = 10000;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
