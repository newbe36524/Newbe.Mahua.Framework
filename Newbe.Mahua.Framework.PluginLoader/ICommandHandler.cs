namespace Newbe.Mahua.Framework
{
    public interface ICommandHandler
    {
        bool CanHandle(MahuaCommand command);
    }

    public interface IVoidCommandHandler : ICommandHandler
    {
        void Handle(object command);
    }

    public interface IComamndHandler<in TCommand> : IVoidCommandHandler where TCommand : MahuaCommand
    {
        void Handle(TCommand command);
    }

    public interface IResultCommandHandler : ICommandHandler
    {
        object Handle(object command);
    }

    public interface ICommandHanlder<in TCommand, out TCommandResult> : IResultCommandHandler
        where TCommand : MahuaCommand
    {
        TCommandResult Handle(TCommand command);
    }
}