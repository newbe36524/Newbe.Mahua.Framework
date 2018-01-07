using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            MpqApi.Api_SendMsg(CurrentQq, 1, 0, null, message.ToQq, message.Message);
        }
    }
}
