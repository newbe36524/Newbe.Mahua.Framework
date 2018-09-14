namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 某群被解散
    /// </summary>
    public class IrEvent216 : IIrEvent
    {
        public int IrEventCode { get; } = 216;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
