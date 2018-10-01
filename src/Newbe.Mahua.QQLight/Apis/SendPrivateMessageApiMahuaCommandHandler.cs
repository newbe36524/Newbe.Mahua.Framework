using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType好友消息, null, message.ToQq, message.Message);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
