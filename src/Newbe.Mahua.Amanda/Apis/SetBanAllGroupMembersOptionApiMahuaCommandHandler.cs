using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SetBanAllGroupMembersOptionApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SetBanAllGroupMembersOptionApiMahuaCommand>
    {
        public SetBanAllGroupMembersOptionApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SetBanAllGroupMembersOptionApiMahuaCommand message)
        {
            AmandaApi.Api_BanGroup(message.ToGroup, message.Enabled);
        }
    }
}
