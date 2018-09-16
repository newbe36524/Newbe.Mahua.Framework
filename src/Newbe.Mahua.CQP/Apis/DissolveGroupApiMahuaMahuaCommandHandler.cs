using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class DissolveGroupApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        public DissolveGroupApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(DissolveGroupApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupLeave(AuthCode, Convert.ToInt64(message.ToGroup), true);
        }
    }
}
