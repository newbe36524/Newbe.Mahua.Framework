using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendLikeApiMahuaCommandHandler : CqpApiCommandHandlerBase<SendLikeApiMahuaCommand>
    {
        public SendLikeApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SendLikeApiMahuaCommand message)
        {
            CoolQApi.CQ_sendLikeV2(AuthCode, Convert.ToInt64(message.ToQq), 1);
        }
    }
}
