using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class PluginStartCommandHandler : CommandHandlerBase<PluginStartCommand>
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _enabledMahuaEvents;

        public PluginStartCommandHandler(IEnumerable<IPluginEnabledMahuaEvent> enabledMahuaEvents)
        {
            _enabledMahuaEvents = enabledMahuaEvents;
        }

        protected override void HandleCore(PluginStartCommand command)
        {
            _enabledMahuaEvents.Handle(x => x.Enabled(new PluginEnabledContext()));
        }
    }

    [Serializable]
    internal class PluginStartCommand : AmandaCommand
    {
    }
}