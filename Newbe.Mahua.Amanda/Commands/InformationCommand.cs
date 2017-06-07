using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class InformationCommandHandler : CommandHandlerBase<InformationCommand, InformationCommandResult>
    {
        private static readonly string SdkVersion = "1";
        private readonly IPluginInfo _pluginInfo;

        public InformationCommandHandler(IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        protected override InformationCommandResult HandleCore(InformationCommand command)
        {
            var info = $"pluginID={_pluginInfo.Id};{Environment.NewLine}" +
                       $"pluginName={_pluginInfo.Name};{Environment.NewLine}" +
                       $"pluginBrief=;{Environment.NewLine}" +
                       $"pluginVersion={_pluginInfo.Version};{Environment.NewLine}" +
                       $"pluginSDK={SdkVersion};{Environment.NewLine}" +
                       $"pluginAuthor={_pluginInfo.Author};{Environment.NewLine}" +
                       $"pluginWindowsTitle={{_TestMenu1=测试窗口1}}{{_TestMenu2=测试窗口2}};";
            return new InformationCommandResult
            {
                Info = info
            };
        }
    }

    [Serializable]
    internal class InformationCommand : AmandaCommand
    {
    }

    [Serializable]
    public class InformationCommandResult : MahuaCommandResult
    {
        public string Info { get; set; }
    }
}