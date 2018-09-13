namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 框架即将重启
    /// </summary>
    public class IrEvent10001 : IIrEvent
    {
        public int IrEventCode { get; } = 10001;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
