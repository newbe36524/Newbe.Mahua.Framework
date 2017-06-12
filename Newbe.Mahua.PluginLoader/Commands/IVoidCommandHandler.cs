namespace Newbe.Mahua.Commands
{
    public interface IVoidCommandHandler : ICommandHandler
    {
        void Handle(object command);
    }
}