using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class EnableGroupAdminApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<EnableGroupAdminApiMahuaCommand>
    {
        public EnableGroupAdminApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(EnableGroupAdminApiMahuaCommand message)
        {
            QqLightApi.Api_SetManager(message.ToGroup, message.ToQq, true);
        }
    }
}
