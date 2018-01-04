using MediatR;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Apis
{
    public interface IApiCommandHandler : ICommandHandler
    {
    }

    public interface IApiCommandHandler<in TCommand> :
        ICommandHandler<TCommand>,
        IApiCommandHandler
        where TCommand : ApiMahuaCommand
    {
    }

    public interface IApiCommandHandler<in TCommand, out TResult> :
        ICommandHandler<TCommand, TResult>,
        IApiCommandHandler
        where TCommand : ApiMahuaCommand<TResult>, IRequest<TResult>
        where TResult : ApiMahuaCommandResult
    {
    }
}
