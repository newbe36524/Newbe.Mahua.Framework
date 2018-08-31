using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RemoveFriendApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RemoveFriendApiMahuaCommand>
    {
        public RemoveFriendApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(RemoveFriendApiMahuaCommand message)
        {
            QqLightApi.Api_DeleteFriend(message.ToQq);
        }
    }
}
