using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class KickGroupMemberApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        public KickGroupMemberApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupKick(
                AuthCode,
                Convert.ToInt64(message.ToGroup),
                Convert.ToInt64(message.ToQq),
                message.RejectForever);
        }
    }
}
