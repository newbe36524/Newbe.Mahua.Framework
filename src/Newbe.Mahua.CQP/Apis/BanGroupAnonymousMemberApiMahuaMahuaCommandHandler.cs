using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class BanGroupAnonymousMemberApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<BanGroupAnonymousMemberApiMahuaCommand>
    {
        public BanGroupAnonymousMemberApiMahuaMahuaCommandHandler(
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
