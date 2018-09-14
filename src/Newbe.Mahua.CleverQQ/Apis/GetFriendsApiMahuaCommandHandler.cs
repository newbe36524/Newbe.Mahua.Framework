using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetFriendsApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
            var friendsString = CleverQQApi.Api_GetFriendList(CurrentQq);
            var re = new GetFriendsApiMahuaCommandResult
            {
                FriendsString = friendsString
            };
            return re;
        }
    }
}
