namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// QQ被手动离线
    /// </summary>
    public class IR_Event1102 : IIR_Event
    {
        public int IR_Event { get; } = 1102;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
