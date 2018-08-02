using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.Commands
{
    public class PluginHotUpgradedCommandHandler
        : ICommandHandler<PluginHotUpgradedCommand>
    {
        private readonly IEnumerable<IPluginHotUpgradedMahuaEvent> _pluginHotUpgradedMahuaEvents;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public PluginHotUpgradedCommandHandler(
            IEnumerable<IPluginHotUpgradedMahuaEvent> pluginHotUpgradedMahuaEvents,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _pluginHotUpgradedMahuaEvents = pluginHotUpgradedMahuaEvents;
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        public void Handle(PluginHotUpgradedCommand message)
        {
            _pluginHotUpgradedMahuaEvents.Handle(x => x.HotUpgraded(new PluginHotUpgradedContext()));
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }
}
