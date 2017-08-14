namespace Newbe.Mahua.Commands
{
    public interface IComamndHandler<in TCommand> : ICommandHandler<TCommand, EmptyCommandResult> where TCommand : MahuaCommand
    {
    }
}
