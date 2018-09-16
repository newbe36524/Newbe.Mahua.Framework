using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetFriendsApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
            var friendsString = QqLightApi.Api_GetFriendList();
            var re = new GetFriendsApiMahuaCommandResult
            {
                FriendsString = friendsString
            };
            return re;
        }
    }
}
