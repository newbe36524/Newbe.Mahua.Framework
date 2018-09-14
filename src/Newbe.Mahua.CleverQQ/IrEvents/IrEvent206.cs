namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 群管关闭全群禁言
    /// </summary>
    public class IrEvent206 : IIrEvent
    {
        public int IrEventCode { get; } = 206;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
