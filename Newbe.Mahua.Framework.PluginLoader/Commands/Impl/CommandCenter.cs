using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.Framework.Commands.Impl
{
    internal class CommandCenter : ICommandCenter
    {
        private readonly IEnumerable<IVoidCommandHandler> _commandHandlers;
        private readonly IEnumerable<IResultCommandHandler> _resultCommandHandlers;

        public CommandCenter(IEnumerable<IVoidCommandHandler> commandHandlers,
            IEnumerable<IResultCommandHandler> resultCommandHandlers)
        {
            _commandHandlers = commandHandlers;
            _resultCommandHandlers = resultCommandHandlers;
        }

        void ICommandCenter.Handle(MahuaCommand command)
        {
            var commandHandlers = _commandHandlers.Where(x => x.CanHandle(command));
            foreach (var commandHandler in commandHandlers.Where(x => x.CanHandle(command)))
            {
                commandHandler.Handle(command);
            }
        }

        void ICommandCenter.Handle(MahuaCommand command, out MahuaCommandResult mahuaCommandResult)
        {
            var commandHandlers = _resultCommandHandlers.FirstOrDefault(x => x.CanHandle(command));
            mahuaCommandResult = (MahuaCommandResult) commandHandlers?.Handle(command);
        }
    }
}