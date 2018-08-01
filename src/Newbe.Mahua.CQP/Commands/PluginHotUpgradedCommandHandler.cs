using Newbe.Mahua.Commands;
using Newbe.Mahua.CQP.NativeApi;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Commands
{
    public class PluginHotUpgradedCommandHandler
        : ICommandHandler<PluginHotUpgradedCommand>
    {
        private readonly IEnumerable<IPluginHotUpgradedMahuaEvent> _pluginHotUpgradedMahuaEvents;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public PluginHotUpgradedCommandHandler(
            IEnumerable<IPluginHotUpgradedMahuaEvent> pluginHotUpgradedMahuaEvents,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _pluginHotUpgradedMahuaEvents = pluginHotUpgradedMahuaEvents;
            _initializationMahuaEvents = initializationMahuaEvents;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        public void Handle(PluginHotUpgradedCommand message)
        {
            _cqpAuthCodeContainer.Load();
            _pluginHotUpgradedMahuaEvents.Handle(x => x.HotUpgraded(new PluginHotUpgradedContext()));
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }
}
