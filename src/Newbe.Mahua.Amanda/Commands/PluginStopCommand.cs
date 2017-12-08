using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    [DataContract]
    public class PluginStopCommand : AmandaCommand
    {
    }

    internal class PluginStopCommandHandler : ICommandHandler<PluginStopCommand>
    {
        private readonly IEnumerable<IPluginDisabledMahuaEvent> _pluginDisabledMahuaEvents;

        public PluginStopCommandHandler(IEnumerable<IPluginDisabledMahuaEvent> pluginDisabledMahuaEvents)
        {
            _pluginDisabledMahuaEvents = pluginDisabledMahuaEvents;
        }

        public void Handle(PluginStopCommand command)
        {
            _pluginDisabledMahuaEvents.Handle(x => x.Disable(new PluginDisabledContext()));
        }
    }
}
