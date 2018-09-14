using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SendDiscussMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType讨论组消息, message.ToDiscuss, null, message.Message);
        }
    }
}
