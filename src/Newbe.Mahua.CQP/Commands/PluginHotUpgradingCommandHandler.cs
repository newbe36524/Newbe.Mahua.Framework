using Newbe.Mahua.Commands;
using Newbe.Mahua.CQP.NativeApi;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Commands
{
    public class PluginHotUpgradingCommandHandler
        : ICommandHandler<PluginHotUpgradingCommand, PluginHotUpgradingCommandResult>
    {
        private readonly IEnumerable<IPluginHotUpgradingMahuaEvent> _hotUpgradingMahuaEvents;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public PluginHotUpgradingCommandHandler(
            IEnumerable<IPluginHotUpgradingMahuaEvent> hotUpgradingMahuaEvents,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _hotUpgradingMahuaEvents = hotUpgradingMahuaEvents;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
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
                _cqpAuthCodeContainer.Save();
            }
            return re;
        }
    }
}
