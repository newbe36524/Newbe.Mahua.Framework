using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SetGroupMemberSpecialTitleApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<SetGroupMemberSpecialTitleApiMahuaCommand>
    {
        public SetGroupMemberSpecialTitleApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SetGroupMemberSpecialTitleApiMahuaCommand message)
        {
            var total = message.Duration == TimeSpan.MaxValue ? -1 : (long)message.Duration.TotalSeconds;
            CoolQApi.CQ_setGroupSpecialTitle(
                AuthCode,
                Convert.ToInt64(message.ToGroup),
                Convert.ToInt64(message.ToQq),
                message.SpecialTitle,
                total);
        }
    }
}
