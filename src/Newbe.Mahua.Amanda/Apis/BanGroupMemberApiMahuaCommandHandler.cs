using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class BanGroupMemberApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<BanGroupMemberApiMahuaCommand>
    {
        public BanGroupMemberApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(BanGroupMemberApiMahuaCommand message)
        {
            AmandaApi.Api_Ban(message.ToGroup, message.ToQq, (int)message.Duration.TotalSeconds);
        }
    }
}
