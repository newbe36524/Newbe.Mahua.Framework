using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendDiscussMessageApiMahuaCommand message)
        {
            CleverQQApi.Api_SendMsg(CurrentQq, 3, message.ToDiscuss, null, message.Message, -2);
        }
    }
}
