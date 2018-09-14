using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RejectGroupJoiningInvitationApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RejectGroupJoiningInvitationApiMahuaCommand>
    {
        public RejectGroupJoiningInvitationApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(RejectGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo 需要验证
            QqLightApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningInvitationId,
                QqLightConstants.Operation拒绝,
                null);
        }
    }
}
