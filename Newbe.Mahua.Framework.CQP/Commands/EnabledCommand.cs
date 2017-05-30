using System;
using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class EnabledCommandHandler : CommandHandlerBase<EnabledCommand>
    {
        protected override void HandleCore(EnabledCommand command)
        {
        }
    }

    [Serializable]
    internal class EnabledCommand : CqpCommand
    {
    }
}