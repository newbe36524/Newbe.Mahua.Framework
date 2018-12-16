using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 将QQ移出黑名单
    /// </summary>
    public class RemoveBanFriendApiMahuaCommandHandler
		: IApiCommandHandler<RemoveBanFriendApiMahuaCommand>
    {
        public void Handle(RemoveBanFriendApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

