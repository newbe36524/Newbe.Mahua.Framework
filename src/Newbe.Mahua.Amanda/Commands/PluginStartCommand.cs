using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class PluginStartCommandHandler : ICommandHandler<PluginStartCommand>
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _enabledMahuaEvents;

        public PluginStartCommandHandler(IEnumerable<IPluginEnabledMahuaEvent> enabledMahuaEvents)
        {
            _enabledMahuaEvents = enabledMahuaEvents;
        }

        public void Handle(PluginStartCommand command)
        {
            _enabledMahuaEvents.Handle(x => x.Enabled(new PluginEnabledContext()));
        }
    }

    [DataContract]
    public class PluginStartCommand : AmandaCommand
    {
    }
}
