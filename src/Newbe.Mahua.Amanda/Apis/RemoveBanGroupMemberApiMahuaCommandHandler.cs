using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class RemoveBanGroupMemberApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        public RemoveBanGroupMemberApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            AmandaApi.Api_Ban(message.ToGroup, message.ToQq, 0);
        }
    }
}
