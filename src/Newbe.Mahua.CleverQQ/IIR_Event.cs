namespace Newbe.Mahua.CleverQQ
{
    public interface IIR_Event
    {
        int IR_Event { get; }

        void Handle(IR_EventInput eventFunInput);
    }
}
