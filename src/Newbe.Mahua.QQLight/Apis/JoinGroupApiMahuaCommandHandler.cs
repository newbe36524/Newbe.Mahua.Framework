using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class JoinGroupApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<JoinGroupApiMahuaCommand>
    {
        public JoinGroupApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(JoinGroupApiMahuaCommand message)
        {
            QqLightApi.Api_AddGroup(message.ToGroup, message.Reason);
        }
    }
}
