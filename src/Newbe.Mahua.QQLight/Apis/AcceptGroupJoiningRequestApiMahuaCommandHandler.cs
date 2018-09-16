using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class AcceptGroupJoiningRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        public AcceptGroupJoiningRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningRequestId,
                QqLightConstants.Operation同意,
                null);
        }
    }
}
