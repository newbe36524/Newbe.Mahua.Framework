using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendGroupMessageApiMahuaCommand message)
        {
            CleverQQApi.Api_SendMsg(CurrentQq, 2, message.ToGroup, null, message.Message, -2);
        }
    }
}
