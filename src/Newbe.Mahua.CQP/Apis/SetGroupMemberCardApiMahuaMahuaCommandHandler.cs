using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SetGroupMemberCardApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        public SetGroupMemberCardApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupCard(
                AuthCode,
                Convert.ToInt64(message.ToGroup),
                Convert.ToInt64(message.ToQq),
                message.GroupMemberCard);
        }
    }
}
