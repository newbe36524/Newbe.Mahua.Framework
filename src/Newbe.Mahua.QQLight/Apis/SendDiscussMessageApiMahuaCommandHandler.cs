using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType讨论组消息, message.ToDiscuss, null, message.Message);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
