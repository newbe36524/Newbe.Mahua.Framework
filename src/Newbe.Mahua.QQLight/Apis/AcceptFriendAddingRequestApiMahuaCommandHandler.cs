using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class AcceptFriendAddingRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public AcceptFriendAddingRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(AcceptFriendAddingRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetFriendAdd(message.FromQq, QqLightConstants.Operation同意, null);
        }
    }
}
