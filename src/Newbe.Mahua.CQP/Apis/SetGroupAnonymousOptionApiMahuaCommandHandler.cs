using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SetGroupAnonymousOptionApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<SetGroupAnonymousOptionApiMahuaCommand>
    {
        public SetGroupAnonymousOptionApiMahuaCommandHandler(
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
