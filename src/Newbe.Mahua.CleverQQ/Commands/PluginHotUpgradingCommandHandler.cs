using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.Commands
{
    public class PluginHotUpgradingCommandHandler
        : ICommandHandler<PluginHotUpgradingCommand, PluginHotUpgradingCommandResult>
    {
        private readonly IEnumerable<IPluginHotUpgradingMahuaEvent> _hotUpgradingMahuaEvents;

        public PluginHotUpgradingCommandHandler(
            IEnumerable<IPluginHotUpgradingMahuaEvent> hotUpgradingMahuaEvents)
        {
            _hotUpgradingMahuaEvents = hotUpgradingMahuaEvents;
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
            return re;
        }
    }
}
