namespace Newbe.Mahua.CleverQQ
{
    public interface IIrEvent
    {
        int IrEventCode { get; }

        void Handle(IrEventInput eventFunInput);
    }
}
