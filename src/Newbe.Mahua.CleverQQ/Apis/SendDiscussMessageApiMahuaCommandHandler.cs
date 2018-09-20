using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            CleverQQApi.Api_SendMsg(CurrentQq, 3, message.ToDiscuss, null, message.Message, -2);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
