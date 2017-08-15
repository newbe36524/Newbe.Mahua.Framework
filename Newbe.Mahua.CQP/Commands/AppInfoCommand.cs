using Newbe.Mahua.Commands;

namespace Newbe.Mahua.CQP.Commands
{
    internal class AppInfoCommandHandler : ICommandHandler<AppInfoCommand, AppInfoCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;

        public AppInfoCommandHandler(IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }


        public AppInfoCommandResult Handle(AppInfoCommand message)
        {
            return new AppInfoCommandResult
            {
                AppId = _pluginInfo.Id,
            };
        }
    }

    internal class AppInfoCommandResult : CqpCommandResult
    {
        public string AppId { get; set; }
    }

    internal class AppInfoCommand : CqpCommand<AppInfoCommandResult>
    {
    }
}
