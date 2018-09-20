using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            CleverQQApi.Api_SendMsg(CurrentQq, 1, null, message.ToQq, message.Message, -2);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
