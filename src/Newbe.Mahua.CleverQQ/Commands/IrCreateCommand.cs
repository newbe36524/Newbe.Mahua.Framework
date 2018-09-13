using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CleverQQ.Commands
{
    public class IrCreateCommandHandler : ICommandHandler<IrCreateCommand, IrCreateCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;

        public IrCreateCommandHandler(
            IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        public IrCreateCommandResult Handle(IrCreateCommand message)
        {
            return new IrCreateCommandResult
            {
                Info = $"插件名称{{{_pluginInfo.Id}}}\n插件版本{{{_pluginInfo.Version}}}\n插件作者{{{_pluginInfo.Author}}}\n插件说明{{{_pluginInfo.Description}}}\n"
                + "插件skey{8956RTEWDFG3216598WERDF3}\n插件sdk{S3}"
            };
        }
    }

    [DataContract]
    public class IrCreateCommand : CleverQQCommand<IrCreateCommandResult>
    {
    }

    [DataContract]
    public class IrCreateCommandResult : CleverQQCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }
}
