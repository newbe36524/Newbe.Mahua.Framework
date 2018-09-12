namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 框架加载完成
    /// </summary>
    public class IR_Event10000 : IIR_Event
    {
        public int IR_Event { get; } = 10000;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
