using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class RejectGroupJoiningInvitationApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<RejectGroupJoiningInvitationApiMahuaCommand>
    {
        public RejectGroupJoiningInvitationApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(RejectGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo 需要验证
            AmandaApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningInvitationId,
                AmandaConstants.Operation拒绝,
                null);
        }
    }
}
