using Newbe.Mahua.Framework.CQP.CommandResults;
using Newbe.Mahua.Framework.CQP.Commands;

namespace Newbe.Mahua.Framework.CQP.CommandHandlers
{
    public class AppInfoCommandHandler : CommandHandlerBase<AppInfoCommand, AppInfoCommandResult>
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
                AppId = _pluginInfo.Id.ToLowerInvariant(),
            };
        }
    }
}