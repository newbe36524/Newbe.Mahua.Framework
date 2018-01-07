using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class AcceptGroupJoiningInvitationApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<AcceptGroupJoiningInvitationApiMahuaCommand>
    {
        public AcceptGroupJoiningInvitationApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(AcceptGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo 需要验证
            AmandaApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningInvitationId,
                AmandaConstants.Operation同意,
                null);
        }
    }
}
