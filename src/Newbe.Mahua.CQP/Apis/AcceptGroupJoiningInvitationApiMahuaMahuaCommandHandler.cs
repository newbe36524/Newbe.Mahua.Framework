using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class AcceptGroupJoiningInvitationApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<AcceptGroupJoiningInvitationApiMahuaCommand>
    {
        public AcceptGroupJoiningInvitationApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(AcceptGroupJoiningInvitationApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAddRequestV2(
                AuthCode,
                message.GroupJoiningInvitationId,
                CoolConstants.RequestType请求群邀请,
                CoolConstants.AcceptType请求通过,
                null);
        }
    }
}
