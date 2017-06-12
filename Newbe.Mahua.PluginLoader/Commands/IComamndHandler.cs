namespace Newbe.Mahua.Commands
{
    public interface IComamndHandler<in TCommand> : IVoidCommandHandler where TCommand : MahuaCommand
    {
        void Handle(TCommand command);
    }
}