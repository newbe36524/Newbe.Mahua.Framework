namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 插件被点击 点击方式参考子类型.  1=左键单击 2=右键单击 3=左键双击
    /// </summary>
    public class IR_Event12003 : IIR_Event
    {
        public int IR_Event { get; } = 12003;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo there is no mahua event
        }
    }
}
