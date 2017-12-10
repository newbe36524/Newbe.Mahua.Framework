using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class EnabledCommand : CqpCommand
    {
    }

    internal class EnabledCommandHandler : ICommandHandler<EnabledCommand>
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _pluginEnabledMahuaEvents;

        public EnabledCommandHandler(IEnumerable<IPluginEnabledMahuaEvent> pluginEnabledMahuaEvents)
        {
            _pluginEnabledMahuaEvents = pluginEnabledMahuaEvents;
        }

        public void Handle(EnabledCommand message)
        {
            _pluginEnabledMahuaEvents.Handle(x => x.Enabled(new PluginEnabledContext()));
        }
    }
}
