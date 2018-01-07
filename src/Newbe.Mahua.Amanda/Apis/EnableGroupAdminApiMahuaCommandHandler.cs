using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class EnableGroupAdminApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<EnableGroupAdminApiMahuaCommand>
    {
        public EnableGroupAdminApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(EnableGroupAdminApiMahuaCommand message)
        {
            AmandaApi.Api_SetManager(message.ToGroup, message.ToQq, true);
        }
    }
}
