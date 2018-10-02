using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendGroupMessageApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>
    {
        public SendGroupMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
            MpqApi.Api_SendMsg(CurrentQq, 2, 0, message.ToGroup, null, message.Message);
            var re = new SendGroupMessageApiMahuaCommandResult
            {
                MessageCancelToken = MpqCancelMessageToken.EmptyActionToken
            };
            return re;
        }
    }
}