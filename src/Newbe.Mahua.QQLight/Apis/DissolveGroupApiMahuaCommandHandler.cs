using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class DissolveGroupApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        public DissolveGroupApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(DissolveGroupApiMahuaCommand message)
        {
            QqLightApi.Api_RemoveGroup(message.ToGroup);
        }
    }
}
