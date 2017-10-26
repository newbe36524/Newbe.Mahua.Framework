namespace Newbe.Mahua.Commands
{
    public interface ICommandCenter
    {
        TResult HandleWithResult<TCommand, TResult>(TCommand command)
            where TCommand : MahuaCommand<TResult> where TResult : MahuaCommandResult;

        void Handle<TCommand>(TCommand command) where TCommand : MahuaCommand;
    }
}
