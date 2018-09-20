using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendPrivateMessageApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        public SendPrivateMessageApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_sendPrivateMsg(AuthCode, Convert.ToInt64(message.ToQq), message.Message);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageId = source
            };
            return re;
        }
    }
}
