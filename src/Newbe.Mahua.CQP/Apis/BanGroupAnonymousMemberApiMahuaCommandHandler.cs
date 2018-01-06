using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    public class BanGroupAnonymousMemberApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<BanGroupAnonymousMemberApiMahuaCommand>
    {
        public BanGroupAnonymousMemberApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(BanGroupAnonymousMemberApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAnonymousBan(
                AuthCode,
                Convert.ToInt64(message.ToGroup),
                message.Anonymous,
                (long)message.Duration.TotalSeconds);
        }
    }
}
