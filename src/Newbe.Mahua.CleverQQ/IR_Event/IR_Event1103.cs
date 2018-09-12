namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// QQ被强制离线
    /// </summary>
    public class IR_Event1103 : IIR_Event
    {
        public int IR_Event { get; } = 1103;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
