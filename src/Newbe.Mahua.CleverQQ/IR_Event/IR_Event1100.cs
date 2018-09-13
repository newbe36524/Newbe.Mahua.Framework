namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 添加了一个新的帐号
    /// </summary>
    public class IR_Event1100 : IIR_Event
    {
        public int IR_Event { get; } = 1100;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
