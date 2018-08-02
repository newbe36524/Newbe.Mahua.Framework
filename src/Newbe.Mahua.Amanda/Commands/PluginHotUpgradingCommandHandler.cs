using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.Amanda.Commands
{
    public class PluginHotUpgradingCommandHandler
        : ICommandHandler<PluginHotUpgradingCommand, PluginHotUpgradingCommandResult>
    {
        private readonly IEnumerable<IPluginHotUpgradingMahuaEvent> _hotUpgradingMahuaEvents;
        private readonly IAmandaAuthCodeContainer _amandaAuthCodeContainer;

        public PluginHotUpgradingCommandHandler(
            IEnumerable<IPluginHotUpgradingMahuaEvent> hotUpgradingMahuaEvents,
            IAmandaAuthCodeContainer amandaAuthCodeContainer)
        {
            _hotUpgradingMahuaEvents = hotUpgradingMahuaEvents;
            _amandaAuthCodeContainer = amandaAuthCodeContainer;
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
                _amandaAuthCodeContainer.Save();
            }
            return re;
        }
    }
}
