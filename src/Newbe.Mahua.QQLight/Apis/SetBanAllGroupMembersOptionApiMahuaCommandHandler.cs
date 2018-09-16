using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SetBanAllGroupMembersOptionApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SetBanAllGroupMembersOptionApiMahuaCommand>
    {
        public SetBanAllGroupMembersOptionApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SetBanAllGroupMembersOptionApiMahuaCommand message)
        {
            QqLightApi.Api_BanGroup(message.ToGroup, message.Enabled);
        }
    }
}
