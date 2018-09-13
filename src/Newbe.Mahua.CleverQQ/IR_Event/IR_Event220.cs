namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 被批准入群
    /// </summary>
    public class IR_Event220 : IIR_Event
    {
        public int IR_Event { get; } = 220;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
