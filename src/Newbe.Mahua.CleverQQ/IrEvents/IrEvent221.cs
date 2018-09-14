namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 被拒绝入群
    /// </summary>
    public class IrEvent221 : IIrEvent
    {
        public int IrEventCode { get; } = 221;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
