using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendLikeApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendLikeApiMahuaCommand>
    {
        public SendLikeApiMahuaMahuaCommandHandler(
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
