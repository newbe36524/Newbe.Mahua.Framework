using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(SendGroupMessageApiMahuaCommand message)
        {
            MpqApi.Api_SendMsg(CurrentQq, 2, 0, message.ToGroup, null, message.Message);
        }
    }
}
