namespace Newbe.Mahua.Framework.Commands
{
    public interface IVoidCommandHandler : ICommandHandler
    {
        void Handle(object command);
    }
}