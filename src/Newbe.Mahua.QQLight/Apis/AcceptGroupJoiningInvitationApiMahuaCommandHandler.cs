using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class AcceptGroupJoiningInvitationApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<AcceptGroupJoiningInvitationApiMahuaCommand>
    {
        public AcceptGroupJoiningInvitationApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(AcceptGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo 需要验证
            QqLightApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningInvitationId,
                QqLightConstants.Operation同意,
                null);
        }
    }
}
