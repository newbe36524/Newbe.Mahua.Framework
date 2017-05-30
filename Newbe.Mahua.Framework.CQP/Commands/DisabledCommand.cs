using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class DisabledCommandHandler : CommandHandlerBase<DisabledCommand>
    {
        private readonly IEnumerable<IPluginDisabledMahuaEvent> _pluginDisabledMahuaEvents;

        public DisabledCommandHandler(IEnumerable<IPluginDisabledMahuaEvent> pluginDisabledMahuaEvents)
        {
            _pluginDisabledMahuaEvents = pluginDisabledMahuaEvents;
        }

        protected override void HandleCore(DisabledCommand command)
        {
            _pluginDisabledMahuaEvents.Handle(x => x.Disable());
        }
    }

    internal class DisabledCommand : CqpCommand
    {
    }
}