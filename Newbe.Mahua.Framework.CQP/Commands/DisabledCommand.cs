using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class DisabledCommandHandler : CommandHandlerBase<DisabledCommand>
    {
        private readonly IPluginDisabledMahuaEvent _pluginDisabledMahuaEvent;

        public DisabledCommandHandler(IPluginDisabledMahuaEvent pluginDisabledMahuaEvent)
        {
            _pluginDisabledMahuaEvent = pluginDisabledMahuaEvent;
        }

        protected override void HandleCore(DisabledCommand command)
        {
            _pluginDisabledMahuaEvent.Disable();
        }
    }

    internal class DisabledCommand : CqpCommand
    {
    }
}