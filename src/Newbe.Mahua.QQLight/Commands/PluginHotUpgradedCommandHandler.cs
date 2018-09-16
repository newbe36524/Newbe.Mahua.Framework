using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.QQLight.Commands
{
    public class PluginHotUpgradedCommandHandler
        : ICommandHandler<PluginHotUpgradedCommand>
    {
        private readonly IEnumerable<IPluginHotUpgradedMahuaEvent> _pluginHotUpgradedMahuaEvents;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;
        private readonly IQqLightAuthCodeContainer _QqLightAuthCodeContainer;

        public PluginHotUpgradedCommandHandler(
            IEnumerable<IPluginHotUpgradedMahuaEvent> pluginHotUpgradedMahuaEvents,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents,
            IQqLightAuthCodeContainer QqLightAuthCodeContainer)
        {
            _pluginHotUpgradedMahuaEvents = pluginHotUpgradedMahuaEvents;
            _initializationMahuaEvents = initializationMahuaEvents;
            _QqLightAuthCodeContainer = QqLightAuthCodeContainer;
        }

        public void Handle(PluginHotUpgradedCommand message)
        {
            _QqLightAuthCodeContainer.Load();
            _pluginHotUpgradedMahuaEvents.Handle(x => x.HotUpgraded(new PluginHotUpgradedContext()));
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }
}
