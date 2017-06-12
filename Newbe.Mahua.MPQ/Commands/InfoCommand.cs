using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class InfoCommandHandler : CommandHandlerBase<InfoCommand, InfoCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InfoCommandHandler(IPluginInfo pluginInfo,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _pluginInfo = pluginInfo;
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        protected override InfoCommandResult HandleCore(InfoCommand command)
        {
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
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