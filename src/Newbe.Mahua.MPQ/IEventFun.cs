namespace Newbe.Mahua.MPQ
{
    public interface IEventFun
    {
        int EventFun { get; }

        void Handle(EventFunInput eventFunInput);
    }
}
