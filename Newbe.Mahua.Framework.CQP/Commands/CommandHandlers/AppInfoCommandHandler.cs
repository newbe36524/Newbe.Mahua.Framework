using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.CQP.Commands.CommandResults;

namespace Newbe.Mahua.Framework.CQP.Commands.CommandHandlers
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
}