using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class DisableGroupAdminApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<DisableGroupAdminApiMahuaCommand>
    {
        public DisableGroupAdminApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(DisableGroupAdminApiMahuaCommand message)
        {
            QqLightApi.Api_SetManager(message.ToGroup, message.ToQq, false);
        }
    }
}
