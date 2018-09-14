using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class RejectGroupJoiningInvitationApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<RejectGroupJoiningInvitationApiMahuaCommand>
    {
        public RejectGroupJoiningInvitationApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(RejectGroupJoiningInvitationApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAddRequestV2(
                AuthCode,
                message.GroupJoiningInvitationId,
                CoolConstants.RequestType请求群邀请,
                CoolConstants.AcceptType请求拒绝,
                message.Reason);
        }
    }
}
