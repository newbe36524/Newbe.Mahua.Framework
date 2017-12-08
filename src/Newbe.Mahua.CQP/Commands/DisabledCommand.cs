using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class DisabledCommand : CqpCommand
    {
    }

    internal class DisabledCommandHandler : ICommandHandler<DisabledCommand>
    {
        private readonly IEnumerable<IPluginDisabledMahuaEvent> _pluginDisabledMahuaEvents;

        public DisabledCommandHandler(IEnumerable<IPluginDisabledMahuaEvent> pluginDisabledMahuaEvents)
        {
            _pluginDisabledMahuaEvents = pluginDisabledMahuaEvents;
        }

        public void Handle(DisabledCommand command)
        {
            _pluginDisabledMahuaEvents.Handle(x => x.Disable(new PluginDisabledContext()));
        }
    }
}
