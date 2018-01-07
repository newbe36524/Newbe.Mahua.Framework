using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class BanGroupMemberApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<BanGroupMemberApiMahuaCommand>
    {
        public BanGroupMemberApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(BanGroupMemberApiMahuaCommand message)
        {
            var durationTotalSeconds = (long)message.Duration.TotalSeconds;
            CoolQApi.CQ_setGroupBan(
                AuthCode,
                Convert.ToInt64(message.ToGroup),
                Convert.ToInt64(message.ToQq),
                durationTotalSeconds);
        }
    }
}
