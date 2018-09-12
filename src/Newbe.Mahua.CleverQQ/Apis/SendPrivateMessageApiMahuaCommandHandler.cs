using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            CleverQQApi.Api_SendMsg(CurrentQq, 1,  null, message.ToQq, message.Message, -2);
        }
    }
}
