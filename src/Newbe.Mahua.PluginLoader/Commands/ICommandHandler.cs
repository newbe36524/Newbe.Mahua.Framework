using MediatR;

namespace Newbe.Mahua.Commands
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>, ICommandHandler
        where TCommand : MahuaCommand
    {
    }

    public interface ICommandHandler<in TCommand, out TResult> : IRequestHandler<TCommand, TResult>, ICommandHandler
        where TCommand : MahuaCommand<TResult>, IRequest<TResult>
        where TResult : MahuaCommandResult
    {
    }

}
