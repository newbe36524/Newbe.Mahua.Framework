using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Commands;
using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    [DataContract]
    public class InformationCommand : AmandaCommand<InformationCommandResult>
    {
        [DataMember]
        public string AuthCode { get; set; }
    }

    [DataContract]
    public class InformationCommandResult : AmandaCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }

    internal class InformationCommandHandler : ICommandHandler<InformationCommand, InformationCommandResult>
    {
        private static readonly string SdkVersion = "3";
        private readonly IPluginInfo _pluginInfo;
        private readonly IAmandaAuthCodeContainer _amandaAuthCodeContainer;

        public InformationCommandHandler(
            IPluginInfo pluginInfo,
            IAmandaAuthCodeContainer amandaAuthCodeContainer)
        {
            _pluginInfo = pluginInfo;
            _amandaAuthCodeContainer = amandaAuthCodeContainer;
        }

        public InformationCommandResult Handle(InformationCommand message)
        {
            _amandaAuthCodeContainer.AuthCode = message.AuthCode;
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
