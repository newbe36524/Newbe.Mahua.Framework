namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// QQ长时间无响应或掉线
    /// </summary>
    public class IR_Event1104 : IIR_Event
    {
        public int IR_Event { get; } = 1104;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
