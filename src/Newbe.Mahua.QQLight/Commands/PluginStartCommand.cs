using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class PluginStartCommand : QqLightCommand
    {
    }

    internal class PluginStartCommandHandler : ICommandHandler<PluginStartCommand>
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _enabledMahuaEvents;

        public PluginStartCommandHandler(IEnumerable<IPluginEnabledMahuaEvent> enabledMahuaEvents)
        {
            _enabledMahuaEvents = enabledMahuaEvents;
        }

        public void Handle(PluginStartCommand message)
        {
            _enabledMahuaEvents.Handle(x => x.Enabled(new PluginEnabledContext()));
        }
    }
}
