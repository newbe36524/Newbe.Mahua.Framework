namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 说说被某人评论//无评论具体内容
    /// </summary>
    public class IrEvent107 : IIrEvent
    {
        public int IrEventCode { get; } = 107;

        public void Handle(IrEventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
