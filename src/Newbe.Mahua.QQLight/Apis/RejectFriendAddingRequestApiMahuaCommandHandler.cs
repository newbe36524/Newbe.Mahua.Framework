using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RejectFriendAddingRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RejectFriendAddingRequestApiMahuaCommand>
    {
        public RejectFriendAddingRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetFriendAdd(message.FromQq, QqLightConstants.Operation拒绝, null);
        }
    }
}
