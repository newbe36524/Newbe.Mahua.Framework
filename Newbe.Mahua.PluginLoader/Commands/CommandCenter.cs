using MediatR;
using System.Threading.Tasks;

namespace Newbe.Mahua.Commands
{
    internal class CommandCenter : ICommandCenter
    {
        private readonly IMediator _mediator;

        public CommandCenter(IMediator mediator)
        {
            _mediator = mediator;
        }

        public TResult HandleWithResult<TCommand, TResult>(TCommand command)
            where TCommand : MahuaCommand<TResult> where TResult : MahuaCommandResult
        {
            return _mediator.Send(command).Result;
        }

        public void Handle<TCommand>(TCommand command) where TCommand : MahuaCommand
        {
            Task.WaitAll(_mediator.Send(command));
        }
    }
}
