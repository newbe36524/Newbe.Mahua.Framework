using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class CoolQExitedCommandHandler : CommandHandlerBase<CoolQExitedCommand>
    {
        private readonly IEnumerable<IPlatfromExitedMahuaEvent> _platfromExitedMahuaEvents;

        public CoolQExitedCommandHandler(IEnumerable<IPlatfromExitedMahuaEvent> platfromExitedMahuaEvents)
        {
            _platfromExitedMahuaEvents = platfromExitedMahuaEvents;
        }

        protected override void HandleCore(CoolQExitedCommand command)
        {
            _platfromExitedMahuaEvents.Handle(x => x.Exited(new PlatfromExitedContext()));
        }
    }

    internal class CoolQExitedCommand : CqpCommand
    {
    }
}