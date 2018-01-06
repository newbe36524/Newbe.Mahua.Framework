using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendPrivateMessageApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand>
    {
        public SendPrivateMessageApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            CoolQApi.CQ_sendPrivateMsg(AuthCode, Convert.ToInt64(message.ToQq), message.Message);
        }
    }
}
