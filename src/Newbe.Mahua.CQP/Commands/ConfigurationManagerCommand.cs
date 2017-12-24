using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class ConfigurationManagerCommand : CqpCommand
    {
    }

    public class ConfigurationManagerCommandHandler : ICommandHandler<ConfigurationManagerCommand>
    {
        private readonly IMahuaAdministration _mahuaAdministration;
        private readonly IMahuaApi _mahuaApi;

        public ConfigurationManagerCommandHandler(
            IMahuaAdministration mahuaAdministration,
            IMahuaApi mahuaApi)
        {
            _mahuaAdministration = mahuaAdministration;
            _mahuaApi = mahuaApi;
        }

        public void Handle(ConfigurationManagerCommand message)
        {
            _mahuaAdministration.Show(_mahuaApi.GetContainer());
        }
    }
}
