using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class PluginStartCommandHandler : CommandHandlerBase<PluginStartCommand>
    {
        protected override void HandleCore(PluginStartCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class PluginStartCommand : AmandaCommand
    {
    }
}