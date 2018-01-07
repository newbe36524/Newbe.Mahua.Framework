using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    public class GetFriendsApiMahuaCommandHandler : IApiCommandHandler<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
            var re = new GetFriendsApiMahuaCommandResult
            {
                FriendsString = "这是一段测试好友消息，这段消息会被发送到公告中"
            };
            return re;
        }
    }
}
