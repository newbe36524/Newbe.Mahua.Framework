using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RejectGroupJoiningRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RejectGroupJoiningRequestApiMahuaCommand>
    {
        public RejectGroupJoiningRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningRequestId,
                QqLightConstants.Operation拒绝,
                null);
        }
    }
}
