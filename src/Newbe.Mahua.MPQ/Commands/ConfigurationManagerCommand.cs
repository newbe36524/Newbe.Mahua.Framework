using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    /// <summary>
    /// 处理菜单
    /// </summary>
    public class ConfigurationManagerCommandHandler : ICommandHandler<ConfigurationManagerCommand>
    {
        private readonly IMahuaConfigurationManager _mahuaConfigurationManager;
        private readonly IMahuaApi _mahuaApi;

        public ConfigurationManagerCommandHandler(
            IMahuaConfigurationManager mahuaConfigurationManager,
            IMahuaApi mahuaApi)
        {
            _mahuaConfigurationManager = mahuaConfigurationManager;
            _mahuaApi = mahuaApi;
        }

        public void Handle(ConfigurationManagerCommand message)
        {
            _mahuaConfigurationManager.Show(_mahuaApi.GetContainer());
        }
    }

    [DataContract]
    public class ConfigurationManagerCommand : MpqCommand
    {
    }
}
