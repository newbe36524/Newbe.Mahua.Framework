namespace Newbe.Mahua.Commands
{
    public abstract class CommandHandlerBase<TCommand> : IComamndHandler<TCommand> where TCommand : MahuaCommand
    {
        public EmptyCommandResult Handle(TCommand command)
        {
            HandleCore(command);
            return new EmptyCommandResult();
        }

        protected abstract void HandleCore(TCommand command);

        public bool CanHandle(MahuaCommand command)
        {
            return command is TCommand;
        }

        public object Handle(object command)
        {
            return Handle(command as TCommand);
        }
    }

    public abstract class CommandHandlerBase<TCommand, TResult> : ICommandHandler<TCommand, TResult>
        where TCommand : MahuaCommand
    {
        public TResult Handle(TCommand command)
        {
            return HandleCore(command);
        }

        protected abstract TResult HandleCore(TCommand command);

        public object Handle(object command)
        {
            return Handle(command as TCommand);
        }

        public bool CanHandle(MahuaCommand command)
        {
            return command is TCommand;
        }
    }
}
