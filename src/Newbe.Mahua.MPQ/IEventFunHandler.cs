namespace Newbe.Mahua.MPQ
{
    public interface IEventFunHandler
    {
        int EventFun { get; }

        void Handle(EventFunInput eventFunInput);
    }
}
