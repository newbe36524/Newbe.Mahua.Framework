namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 被删除好友
    /// </summary>
    public class IrEvent104 : IIrEvent
    {
        public int IrEventCode { get; } = 104;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
