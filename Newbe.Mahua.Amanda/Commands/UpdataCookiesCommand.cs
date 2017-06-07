using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class UpdataCookiesCommandHandler : CommandHandlerBase<UpdataCookiesCommand>
    {
        protected override void HandleCore(UpdataCookiesCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class UpdataCookiesCommand : AmandaCommand
    {
    }
}