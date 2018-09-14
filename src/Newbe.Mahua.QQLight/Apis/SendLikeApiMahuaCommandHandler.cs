using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendLikeApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendLikeApiMahuaCommand>
    {
        public SendLikeApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SendLikeApiMahuaCommand message)
        {
            QqLightApi.Api_SendPraise(message.ToQq);
        }
    }
}
