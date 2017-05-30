namespace Newbe.Mahua.Framework.Commands
{
    public interface ICommandHandler
    {
        bool CanHandle(MahuaCommand command);
    }
    public interface ICommandHandler<in TCommand, out TCommandResult> : IResultCommandHandler
        where TCommand : MahuaCommand
    {
        TCommandResult Handle(TCommand command);
    }
}