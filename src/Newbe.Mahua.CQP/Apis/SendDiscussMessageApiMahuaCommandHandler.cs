using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendDiscussMessageApiMahuaCommandHandler : CqpApiCommandHandlerBase<SendDiscussMessageApiMahuaCommand>
    {
        public SendDiscussMessageApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SendDiscussMessageApiMahuaCommand message)
        {
            CoolQApi.CQ_sendDiscussMsg(AuthCode, Convert.ToInt64(message.ToDiscuss), message.Message);
        }
    }
}
