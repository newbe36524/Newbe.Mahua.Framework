using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class CoolQExitedCommand : CqpCommand
    {
    }

    internal class CoolQExitedCommandHandler : ICommandHandler<CoolQExitedCommand>
    {
        private readonly IEnumerable<IPlatfromExitedMahuaEvent> _platfromExitedMahuaEvents;

        public CoolQExitedCommandHandler(IEnumerable<IPlatfromExitedMahuaEvent> platfromExitedMahuaEvents)
        {
            _platfromExitedMahuaEvents = platfromExitedMahuaEvents;
        }

        public void Handle(CoolQExitedCommand message)
        {
            _platfromExitedMahuaEvents.Handle(x => x.Exited(new PlatfromExitedContext()));
        }
    }
}
