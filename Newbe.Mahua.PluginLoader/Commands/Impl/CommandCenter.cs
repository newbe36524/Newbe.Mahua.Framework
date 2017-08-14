using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.Commands.Impl
{
    internal class CommandCenter : ICommandCenter
    {
        private readonly IEnumerable<IResultCommandHandler> _resultCommandHandlers;

        public CommandCenter(IEnumerable<IResultCommandHandler> resultCommandHandlers)
        {
            _resultCommandHandlers = resultCommandHandlers;
        }

        MahuaCommandResult ICommandCenter.Handle(MahuaCommand command)
        {
            var commandHandlers = _resultCommandHandlers.FirstOrDefault(x => x.CanHandle(command));
            var mahuaCommandResult = (MahuaCommandResult)commandHandlers?.Handle(command);
            return mahuaCommandResult;
        }
    }
}
