using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 获取好友列表
    /// </summary>
    public class GetFriendsApiMahuaCommandHandler
		: IApiCommandHandler<GetFriendsApiMahuaCommand,GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

