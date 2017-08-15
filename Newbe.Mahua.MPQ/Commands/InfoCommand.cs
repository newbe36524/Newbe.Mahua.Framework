using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class InfoCommandHandler : ICommandHandler<InfoCommand, InfoCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InfoCommandHandler(IPluginInfo pluginInfo,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _pluginInfo = pluginInfo;
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        public InfoCommandResult Handle(InfoCommand command)
        {
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
            return new InfoCommandResult
            {
                Info = _pluginInfo.Id + _pluginInfo.Version,
            };
        }
    }

    internal class InfoCommand : MpqCommand<InfoCommandResult>
    {
    }

    internal class InfoCommandResult : MpqCommandResult
    {
        public string Info { get; set; }
    }
}
