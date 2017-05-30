namespace Newbe.Mahua.Framework.Commands
{
    public interface IComamndHandler<in TCommand> : IVoidCommandHandler where TCommand : MahuaCommand
    {
        void Handle(TCommand command);
    }
}