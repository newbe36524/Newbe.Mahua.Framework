using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SetGroupAnonymousOptionApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<SetGroupAnonymousOptionApiMahuaCommand>
    {
        public SetGroupAnonymousOptionApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SetGroupAnonymousOptionApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAnonymous(AuthCode, Convert.ToInt64(message.ToGroup), message.Enabled);
        }
    }
}
