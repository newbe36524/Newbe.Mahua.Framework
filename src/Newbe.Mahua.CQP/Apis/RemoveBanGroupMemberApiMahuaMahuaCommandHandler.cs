using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class RemoveBanGroupMemberApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        public RemoveBanGroupMemberApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupBan(AuthCode, Convert.ToInt64(message.ToGroup), Convert.ToInt64(message.ToQq), 0);
        }
    }
}
