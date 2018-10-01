using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType群消息, message.ToGroup, null, message.Message);
            var re = new SendGroupMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
