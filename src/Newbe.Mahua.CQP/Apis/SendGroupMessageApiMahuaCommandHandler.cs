using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendGroupMessageApiMahuaCommandHandler : CqpApiCommandHandlerBase<SendGroupMessageApiMahuaCommand>
    {
        public SendGroupMessageApiMahuaCommandHandler(
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
