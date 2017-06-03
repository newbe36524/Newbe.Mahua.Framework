using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
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

    [Serializable]
    internal class CoolQExitedCommand : CqpCommand
    {
    }
}