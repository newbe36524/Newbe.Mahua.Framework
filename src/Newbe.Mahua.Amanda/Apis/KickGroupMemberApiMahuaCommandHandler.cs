using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class KickGroupMemberApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        public KickGroupMemberApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            AmandaApi.Api_RemoveMember(message.ToGroup, message.ToQq, message.RejectForever);
        }
    }
}
