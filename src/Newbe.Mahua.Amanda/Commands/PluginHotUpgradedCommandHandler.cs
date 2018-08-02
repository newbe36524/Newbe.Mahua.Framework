using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.Amanda.Commands
{
    public class PluginHotUpgradedCommandHandler
        : ICommandHandler<PluginHotUpgradedCommand>
    {
        private readonly IEnumerable<IPluginHotUpgradedMahuaEvent> _pluginHotUpgradedMahuaEvents;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;
        private readonly IAmandaAuthCodeContainer _amandaAuthCodeContainer;

        public PluginHotUpgradedCommandHandler(
            IEnumerable<IPluginHotUpgradedMahuaEvent> pluginHotUpgradedMahuaEvents,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents,
            IAmandaAuthCodeContainer amandaAuthCodeContainer)
        {
            _pluginHotUpgradedMahuaEvents = pluginHotUpgradedMahuaEvents;
            _initializationMahuaEvents = initializationMahuaEvents;
            _amandaAuthCodeContainer = amandaAuthCodeContainer;
        }

        public void Handle(PluginHotUpgradedCommand message)
        {
            _amandaAuthCodeContainer.Load();
            _pluginHotUpgradedMahuaEvents.Handle(x => x.HotUpgraded(new PluginHotUpgradedContext()));
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }
}
