using Newbe.Mahua.Commands;
using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    [DataContract]
    public class InformationCommand : AmandaCommand<InformationCommandResult>
    {
    }

    [DataContract]
    public class InformationCommandResult : AmandaCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }

    internal class InformationCommandHandler : ICommandHandler<InformationCommand, InformationCommandResult>
    {
        private static readonly string SdkVersion = "1";
        private readonly IPluginInfo _pluginInfo;

        public InformationCommandHandler(IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        public InformationCommandResult Handle(InformationCommand message)
        {
            var info = $"pluginID={_pluginInfo.Id};{Environment.NewLine}" +
                       $"pluginName={_pluginInfo.Name};{Environment.NewLine}" +
                       $"pluginBrief={_pluginInfo.Description};{Environment.NewLine}" +
                       $"pluginVersion={_pluginInfo.Version};{Environment.NewLine}" +
                       $"pluginSDK={SdkVersion};{Environment.NewLine}" +
                       $"pluginAuthor={_pluginInfo.Author};{Environment.NewLine}" +
                       $"pluginWindowsTitle={{_TestMenu1=设置中心}};";
            return new InformationCommandResult
            {
                Info = info
            };
        }
    }
}
