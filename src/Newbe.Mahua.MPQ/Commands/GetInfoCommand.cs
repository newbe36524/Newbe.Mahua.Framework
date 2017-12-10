using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class GetInfoCommandHandler : ICommandHandler<GetInfoCommand, GetInfoCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;

        public GetInfoCommandHandler(
            IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        public GetInfoCommandResult Handle(GetInfoCommand message)
        {
            return new GetInfoCommandResult
            {
                Info = $"{_pluginInfo.Description}【{_pluginInfo.Author}({_pluginInfo.Version})】"
            };
        }
    }

    [DataContract]
    public class GetInfoCommand : MpqCommand<GetInfoCommandResult>
    {
    }

    [DataContract]
    public class GetInfoCommandResult : MpqCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }
}
