namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// QQ被强制离线
    /// </summary>
    public class IrEvent1103 : IIrEvent
    {
        public int IrEventCode { get; } = 1103;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
