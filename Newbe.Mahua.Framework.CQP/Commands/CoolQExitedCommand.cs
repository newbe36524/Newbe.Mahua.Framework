using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class CoolQExitedCommandHandler : CommandHandlerBase<CoolQExitedCommand>
    {
        private readonly IPlatfromExitedMahuaEvent _platfromExitedMahuaEvent;

        public CoolQExitedCommandHandler(IPlatfromExitedMahuaEvent platfromExitedMahuaEvent)
        {
            _platfromExitedMahuaEvent = platfromExitedMahuaEvent;
        }

        protected override void HandleCore(CoolQExitedCommand command)
        {
            _platfromExitedMahuaEvent.Exited();
        }
    }

    internal class CoolQExitedCommand : CqpCommand
    {
    }
}