using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendGroupMessageApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>
    {
        public SendGroupMessageApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_sendGroupMsg(AuthCode, Convert.ToInt64(message.ToGroup), message.Message);
            var re = new SendGroupMessageApiMahuaCommandResult
            {
                MessageId = source
            };
            return re;
        }
    }
}
