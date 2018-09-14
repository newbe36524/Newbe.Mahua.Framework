namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 对象被解除禁言
    /// </summary>
    public class IrEvent204 : IIrEvent
    {
        public int IrEventCode { get; } = 204;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
