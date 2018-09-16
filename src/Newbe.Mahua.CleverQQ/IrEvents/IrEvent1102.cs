namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// QQ被手动离线
    /// </summary>
    public class IrEvent1102 : IIrEvent
    {
        public int IrEventCode { get; } = 1102;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
