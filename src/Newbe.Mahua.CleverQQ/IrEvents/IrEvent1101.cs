namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// QQ登录完成
    /// </summary>
    public class IrEvent1101 : IIrEvent
    {
        public int IrEventCode { get; } = 1101;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
