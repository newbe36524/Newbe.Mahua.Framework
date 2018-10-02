using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            ICleverQqApi cleverQqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverQqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            CleverQQApi.Api_SendMsg(CurrentQq, 3, message.ToDiscuss, null, message.Message, -2);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageCancelToken = CleverQqMessageCancelToken.EmptyActionToken
            };
            return re;
        }
    }
}