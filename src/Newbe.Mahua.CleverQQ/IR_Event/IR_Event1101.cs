namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// QQ登录完成
    /// </summary>
    public class IR_Event1101 : IIR_Event
    {
        public int IR_Event { get; } = 1101;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
