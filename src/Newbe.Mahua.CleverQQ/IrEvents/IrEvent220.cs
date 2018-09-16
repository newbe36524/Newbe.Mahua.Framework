namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 被批准入群
    /// </summary>
    public class IrEvent220 : IIrEvent
    {
        public int IrEventCode { get; } = 220;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
