using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetFriendsApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
            var friendsString = MpqApi.Api_GetFriendList(CurrentQq);
            var re = new GetFriendsApiMahuaCommandResult
            {
                FriendsString = friendsString
            };
            return re;
        }
    }
}
