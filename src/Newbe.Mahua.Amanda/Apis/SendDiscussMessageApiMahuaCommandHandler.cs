using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SendDiscussMessageApiMahuaCommand message)
        {
            AmandaApi.Api_SendMsg(AmandaConstants.MsgType讨论组消息, message.ToDiscuss, null, message.Message);
        }
    }
}
