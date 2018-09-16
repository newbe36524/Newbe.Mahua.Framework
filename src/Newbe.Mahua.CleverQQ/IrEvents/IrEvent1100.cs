namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 添加了一个新的帐号
    /// </summary>
    public class IrEvent1100 : IIrEvent
    {
        public int IrEventCode { get; } = 1100;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
