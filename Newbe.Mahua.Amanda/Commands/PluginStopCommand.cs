using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class PluginStopCommandHandler : CommandHandlerBase<PluginStopCommand>
    {
        protected override void HandleCore(PluginStopCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class PluginStopCommand : AmandaCommand
    {
    }
}