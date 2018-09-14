using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SetGroupAnonymousOptionApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SetGroupAnonymousOptionApiMahuaCommand>
    {
        public SetGroupAnonymousOptionApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SetGroupAnonymousOptionApiMahuaCommand message)
        {
            QqLightApi.Api_SetAnony(message.ToGroup, message.Enabled);
        }
    }
}
