using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using Newbe.Mahua.QQLight.Messages.CancelMessage;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            IQqLightApi qqLightApi)
            : base(qqLightApi)
        {
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType讨论组消息, message.ToDiscuss, null, message.Message);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageCancelToken = QqLightMessageCancelToken.EmptyActionToken
            };
            return re;
        }
    }
}