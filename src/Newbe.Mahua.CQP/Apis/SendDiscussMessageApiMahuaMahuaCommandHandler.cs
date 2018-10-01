using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendDiscussMessageApiMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_sendDiscussMsg(AuthCode, Convert.ToInt64(message.ToDiscuss), message.Message);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageId = source
            };
            return re;
        }
    }
}
