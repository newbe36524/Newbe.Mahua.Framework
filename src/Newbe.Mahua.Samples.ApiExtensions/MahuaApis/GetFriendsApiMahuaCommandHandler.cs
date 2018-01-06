using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    public class GetFriendsApiMahuaCommandHandler : IApiCommandHandler<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
            var re = new GetFriendsApiMahuaCommandResult
            {
                FriendsString = "测试方法好友列表结果"
            };
            return re;
        }
    }
}
