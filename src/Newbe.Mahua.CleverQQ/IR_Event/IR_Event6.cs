namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 收到来自好友的财付通转账
    /// </summary>
    public class IR_Event6 : IIR_Event
    {
        public int IR_Event { get; } = 6;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
