using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendGroupMessageApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand>
    {
        public SendGroupMessageApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SendGroupMessageApiMahuaCommand message)
        {
            CoolQApi.CQ_sendGroupMsg(AuthCode, Convert.ToInt64(message.ToGroup), message.Message);
        }
    }
}
