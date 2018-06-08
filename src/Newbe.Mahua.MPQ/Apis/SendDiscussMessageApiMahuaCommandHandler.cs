using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendDiscussMessageApiMahuaCommand message)
        {
            MpqApi.Api_SendMsg(CurrentQq, 3, 0, message.ToDiscuss, null, message.Message);
        }
    }
}
