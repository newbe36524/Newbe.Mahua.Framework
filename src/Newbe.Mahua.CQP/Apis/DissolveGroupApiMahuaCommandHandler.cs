using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    public class DissolveGroupApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        public DissolveGroupApiMahuaCommandHandler(
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
