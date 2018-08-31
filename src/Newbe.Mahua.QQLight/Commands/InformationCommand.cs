using Newbe.Mahua.Commands;
using Newbe.Mahua.QQLight.NativeApi;
using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class InformationCommand : QqLightCommand<InformationCommandResult>
    {
        [DataMember]
        public string AuthCode { get; set; }
    }

    [DataContract]
    public class InformationCommandResult : QqLightCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }

    internal class InformationCommandHandler : ICommandHandler<InformationCommand, InformationCommandResult>
    {
        private static readonly string SdkVersion = "3";
        private readonly IPluginInfo _pluginInfo;
        private readonly IQqLightAuthCodeContainer _QqLightAuthCodeContainer;

        public InformationCommandHandler(
            IPluginInfo pluginInfo,
            IQqLightAuthCodeContainer QqLightAuthCodeContainer)
        {
            _pluginInfo = pluginInfo;
            _QqLightAuthCodeContainer = QqLightAuthCodeContainer;
        }

        public InformationCommandResult Handle(InformationCommand message)
        {
            _QqLightAuthCodeContainer.AuthCode = message.AuthCode;
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
