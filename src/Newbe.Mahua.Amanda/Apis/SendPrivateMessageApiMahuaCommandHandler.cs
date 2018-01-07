using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            AmandaApi.Api_SendMsg(AmandaConstants.MsgType好友消息, null, message.ToQq, message.Message);
        }
    }
}
