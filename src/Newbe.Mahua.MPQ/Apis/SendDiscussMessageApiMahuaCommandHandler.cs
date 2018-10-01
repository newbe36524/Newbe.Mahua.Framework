using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            MpqApi.Api_SendMsg(CurrentQq, 3, 0, message.ToDiscuss, null, message.Message);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
