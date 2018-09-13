using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CleverQQ.Commands
{
    public class IR_CreateCommandHandler : ICommandHandler<IR_CreateCommand, IR_CreateCommandResult>
    {
        private readonly IPluginInfo _pluginInfo;

        public IR_CreateCommandHandler(
            IPluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
        }

        public IR_CreateCommandResult Handle(IR_CreateCommand message)
        {
            return new IR_CreateCommandResult
            {
                Info = $"插件名称{{{_pluginInfo.Id}}}\n插件版本{{{_pluginInfo.Version}}}\n插件作者{{{_pluginInfo.Author}}}\n插件说明{{{_pluginInfo.Description}}}\n" 
                +"插件skey{8956RTEWDFG3216598WERDF3}\n插件sdk{S3}"
            };
        }
    }

    [DataContract]
    public class IR_CreateCommand : CleverQQCommand<IR_CreateCommandResult>
    {
    }

    [DataContract]
    public class IR_CreateCommandResult : CleverQQCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }
}
