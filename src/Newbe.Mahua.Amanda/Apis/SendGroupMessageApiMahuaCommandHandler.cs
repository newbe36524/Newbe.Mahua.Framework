using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SendGroupMessageApiMahuaCommand message)
        {
            AmandaApi.Api_SendMsg(AmandaConstants.MsgType群消息, message.ToGroup, null, message.Message);
        }
    }
}
