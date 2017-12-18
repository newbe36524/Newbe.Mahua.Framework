using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class AppInfoCommandResult : CqpCommandResult
    {
        [DataMember]
        public string AppId { get; set; }
    }

    [DataContract]
    public class AppInfoCommand : CqpCommand<AppInfoCommandResult>
    {
    }

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
}
