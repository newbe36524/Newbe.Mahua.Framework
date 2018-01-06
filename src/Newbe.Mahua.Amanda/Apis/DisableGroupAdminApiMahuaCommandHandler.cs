using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class DisableGroupAdminApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<DisableGroupAdminApiMahuaCommand>
    {
        public DisableGroupAdminApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(DisableGroupAdminApiMahuaCommand message)
        {
            AmandaApi.Api_SetManager(message.ToGroup, message.ToQq, false);
        }
    }
}
