using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class EnabledCommandHandler : CommandHandlerBase<EnabledCommand>
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _pluginEnabledMahuaEvents;

        public EnabledCommandHandler(IEnumerable<IPluginEnabledMahuaEvent> pluginEnabledMahuaEvents)
        {
            _pluginEnabledMahuaEvents = pluginEnabledMahuaEvents;
        }

        protected override void HandleCore(EnabledCommand command)
        {
            _pluginEnabledMahuaEvents.Handle(x => x.Enabled(new PluginEnabledContext()));
        }
    }

    [Serializable]
    internal class EnabledCommand : CqpCommand
    {
    }
}