using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class DisableGroupAdminApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<DisableGroupAdminApiMahuaCommand>
    {
        public DisableGroupAdminApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(DisableGroupAdminApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAdmin(AuthCode, Convert.ToInt64(message.ToGroup), Convert.ToInt64(message.ToQq), false);
        }
    }
}
