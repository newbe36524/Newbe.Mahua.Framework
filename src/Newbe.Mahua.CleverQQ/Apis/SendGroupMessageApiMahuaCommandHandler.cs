using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
            var messageId = CleverQQApi.Api_SendMsg(CurrentQq, 2, message.ToGroup, null, message.Message, -2);
            var re = new SendGroupMessageApiMahuaCommandResult
            {
                MessageId = messageId
            };
            return re;
        }
    }
}
