namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// QQ长时间无响应或掉线
    /// </summary>
    public class IrEvent1104 : IIrEvent
    {
        public int IrEventCode { get; } = 1104;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
