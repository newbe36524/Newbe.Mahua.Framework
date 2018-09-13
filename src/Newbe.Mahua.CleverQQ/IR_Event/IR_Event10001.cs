namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 框架即将重启
    /// </summary>
    public class IR_Event10001 : IIR_Event
    {
        public int IR_Event { get; } = 10001;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
