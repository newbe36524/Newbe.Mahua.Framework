using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class KickGroupMemberApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        public KickGroupMemberApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            QqLightApi.Api_RemoveMember(message.ToGroup, message.ToQq, message.RejectForever);
        }
    }
}
