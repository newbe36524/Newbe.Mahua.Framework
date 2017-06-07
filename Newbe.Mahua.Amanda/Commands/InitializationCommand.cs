using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class InitializationCommandHandler : CommandHandlerBase<InitializationCommand>
    {
        protected override void HandleCore(InitializationCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class InitializationCommand : AmandaCommand
    {
    }
}