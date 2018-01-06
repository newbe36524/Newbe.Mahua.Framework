using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SendLikeApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SendLikeApiMahuaCommand>
    {
        public SendLikeApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SendLikeApiMahuaCommand message)
        {
            AmandaApi.Api_SendPraise(message.ToQq);
        }
    }
}
