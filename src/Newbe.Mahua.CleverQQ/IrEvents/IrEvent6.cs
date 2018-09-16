namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 收到来自好友的财付通转账
    /// </summary>
    public class IrEvent6 : IIrEvent
    {
        public int IrEventCode { get; } = 6;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
