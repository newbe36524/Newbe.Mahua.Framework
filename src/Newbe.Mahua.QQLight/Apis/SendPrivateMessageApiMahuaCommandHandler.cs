using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType好友消息, null, message.ToQq, message.Message);
        }
    }
}
