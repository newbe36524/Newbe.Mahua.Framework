using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.QQLight.Commands
{
    public class PluginHotUpgradingCommandHandler
        : ICommandHandler<PluginHotUpgradingCommand, PluginHotUpgradingCommandResult>
    {
        private readonly IEnumerable<IPluginHotUpgradingMahuaEvent> _hotUpgradingMahuaEvents;
        private readonly IQqLightAuthCodeContainer _QqLightAuthCodeContainer;

        public PluginHotUpgradingCommandHandler(
            IEnumerable<IPluginHotUpgradingMahuaEvent> hotUpgradingMahuaEvents,
            IQqLightAuthCodeContainer QqLightAuthCodeContainer)
        {
            _hotUpgradingMahuaEvents = hotUpgradingMahuaEvents;
            _QqLightAuthCodeContainer = QqLightAuthCodeContainer;
        }

        public PluginHotUpgradingCommandResult Handle(PluginHotUpgradingCommand message)
        {
            var context = new PluginHotUpgradingContext();
            _hotUpgradingMahuaEvents.Handle(x =>
            {
                x.HotUpgrading(context);
            });
            var re = new PluginHotUpgradingCommandResult
            {
                Canceled = context.Canceled,
                Reason = context.Reason,
            };

            if (!context.Canceled)
            {
                _QqLightAuthCodeContainer.Save();
            }
            return re;
        }
    }
}
