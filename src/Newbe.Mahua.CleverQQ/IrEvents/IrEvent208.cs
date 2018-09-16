namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 群管关闭匿名聊天
    /// </summary>
    public class IrEvent208 : IIrEvent
    {
        public int IrEventCode { get; } = 208;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
