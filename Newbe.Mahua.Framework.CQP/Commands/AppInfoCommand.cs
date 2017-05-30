using System;
using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class AppInfoCommandHandler : CommandHandlerBase<AppInfoCommand, AppInfoCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;

        public AppInfoCommandHandler(IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        protected override AppInfoCommandResult HandleCore(AppInfoCommand command)
        {
            return new AppInfoCommandResult
            {
                AppId = _pluginInfo.Id,
            };
        }
    }

    [Serializable]
    internal class AppInfoCommandResult : MahuaCommandResult
    {
        public string AppId { get; set; }
    }

    [Serializable]
    internal class AppInfoCommand : CqpCommand
    {
    }
}