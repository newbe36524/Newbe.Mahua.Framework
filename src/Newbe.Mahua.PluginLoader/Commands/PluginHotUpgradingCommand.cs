using System.Runtime.Serialization;

namespace Newbe.Mahua.Commands
{
    [DataContract]
    public class PluginHotUpgradingCommand : MahuaCommand<PluginHotUpgradingCommandResult>
    {

    }

    [DataContract]
    public class PluginHotUpgradingCommandResult : MahuaCommandResult
    {
        [DataMember]
        public bool Canceled { get; set; }

        [DataMember]
        public string Reason { get; set; }
    }

}
