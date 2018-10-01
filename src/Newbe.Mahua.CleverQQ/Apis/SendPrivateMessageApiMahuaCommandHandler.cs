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
            var messageId = CleverQQApi.Api_SendMsg(CurrentQq, 1, null, message.ToQq, message.Message, -2);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageId = messageId
            };
            return re;
        }
    }
}
