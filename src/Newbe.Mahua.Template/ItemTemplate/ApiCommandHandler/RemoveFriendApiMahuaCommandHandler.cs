using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 删除好友
    /// </summary>
    public class RemoveFriendApiMahuaCommandHandler
		: IApiCommandHandler<RemoveFriendApiMahuaCommand>
    {
        public void Handle(RemoveFriendApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

