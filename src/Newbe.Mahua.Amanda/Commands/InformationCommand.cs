using Newbe.Mahua.Commands;
using System;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class InformationCommandHandler : ICommandHandler<InformationCommand, InformationCommandResult>
    {
        private static readonly string SdkVersion = "1";
        private readonly IPluginInfo _pluginInfo;

        public InformationCommandHandler(IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        public InformationCommandResult Handle(InformationCommand command)
        {
            var info = $"pluginID={_pluginInfo.Id};{Environment.NewLine}" +
                       $"pluginName={_pluginInfo.Name};{Environment.NewLine}" +
                       $"pluginBrief={_pluginInfo.Description};{Environment.NewLine}" +
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

    internal class InformationCommand : AmandaCommand<InformationCommandResult>
    {
    }

    public class InformationCommandResult : AmandaCommandResult
    {
        public string Info { get; set; }
    }
}
