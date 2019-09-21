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
        private readonly IEnumerable<IPlatformExitedMahuaEvent> _platformExitedMahuaEvents;

        public CoolQExitedCommandHandler(
            IEnumerable<IPlatfromExitedMahuaEvent> platfromExitedMahuaEvents,
            IEnumerable<IPlatformExitedMahuaEvent> platformExitedMahuaEvents)
        {
            _platfromExitedMahuaEvents = platfromExitedMahuaEvents;
            _platformExitedMahuaEvents = platformExitedMahuaEvents;
        }

        public void Handle(CoolQExitedCommand message)
        {
            _platfromExitedMahuaEvents.Handle(x => x.Exited(new PlatfromExitedContext()));
            _platformExitedMahuaEvents.Handle(x => x.Exited(new PlatformExitedContext()));
        }
    }
}
