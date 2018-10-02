using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using Newbe.Mahua.QQLight.Messages.CancelMessage;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            IQqLightApi qqLightApi)
            : base(qqLightApi)
        {
        }

        public override SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType群消息, message.ToGroup, null, message.Message);
            var re = new SendGroupMessageApiMahuaCommandResult
            {
                MessageCancelToken = QqLightMessageCancelToken.EmptyActionToken
            };
            return re;
        }
    }
}