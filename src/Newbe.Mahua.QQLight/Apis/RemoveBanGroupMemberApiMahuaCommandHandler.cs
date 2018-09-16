using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RemoveBanGroupMemberApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        public RemoveBanGroupMemberApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            QqLightApi.Api_Ban(message.ToGroup, message.ToQq, 0);
        }
    }
}
