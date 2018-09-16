using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SendGroupMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType群消息, message.ToGroup, null, message.Message);
        }
    }
}
