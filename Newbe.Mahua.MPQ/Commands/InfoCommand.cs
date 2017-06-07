using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class InfoCommandHandler : CommandHandlerBase<InfoCommand, InfoCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;

        public InfoCommandHandler(IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        protected override InfoCommandResult HandleCore(InfoCommand command)
        {
            return new InfoCommandResult
            {
                Info = _pluginInfo.Id + _pluginInfo.Version,
            };
        }
    }

    [Serializable]
    internal class InfoCommand : MqpCommand
    {
    }

    [Serializable]
    internal class InfoCommandResult : MahuaCommandResult
    {
        public string Info { get; set; }
    }
}