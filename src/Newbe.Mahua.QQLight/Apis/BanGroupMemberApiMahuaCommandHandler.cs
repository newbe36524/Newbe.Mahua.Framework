using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class BanGroupMemberApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<BanGroupMemberApiMahuaCommand>
    {
        public BanGroupMemberApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(BanGroupMemberApiMahuaCommand message)
        {
            QqLightApi.Api_Ban(message.ToGroup, message.ToQq, (int)message.Duration.TotalSeconds);
        }
    }
}
