using System;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class EnabledCommandHandler : CommandHandlerBase<EnabledCommand>
    {
        private readonly IPluginEnabledMahuaEvent _pluginEnabledMahuaEvent;

        public EnabledCommandHandler(IPluginEnabledMahuaEvent pluginEnabledMahuaEvent)
        {
            _pluginEnabledMahuaEvent = pluginEnabledMahuaEvent;
        }

        protected override void HandleCore(EnabledCommand command)
        {
            _pluginEnabledMahuaEvent.Enabled();
        }
    }

    [Serializable]
    internal class EnabledCommand : CqpCommand
    {
    }
}