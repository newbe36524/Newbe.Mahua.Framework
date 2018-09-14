using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class LeaveDiscussApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            CoolQApi.CQ_setDiscussLeave(AuthCode, Convert.ToInt64(message.ToDiscuss));
        }
    }
}
