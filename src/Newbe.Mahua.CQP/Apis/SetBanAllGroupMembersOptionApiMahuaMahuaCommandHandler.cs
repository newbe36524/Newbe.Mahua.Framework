using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SetBanAllGroupMembersOptionApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<SetBanAllGroupMembersOptionApiMahuaCommand>
    {
        public SetBanAllGroupMembersOptionApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SetBanAllGroupMembersOptionApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupWholeBan(AuthCode, Convert.ToInt64(message.ToGroup), message.Enabled);
        }
    }
}
