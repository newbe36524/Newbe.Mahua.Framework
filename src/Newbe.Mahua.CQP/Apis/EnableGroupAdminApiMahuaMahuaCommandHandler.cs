using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class EnableGroupAdminApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<EnableGroupAdminApiMahuaCommand>
    {
        public EnableGroupAdminApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(EnableGroupAdminApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAdmin(AuthCode, Convert.ToInt64(message.ToGroup), Convert.ToInt64(message.ToQq), true);
        }
    }
}
