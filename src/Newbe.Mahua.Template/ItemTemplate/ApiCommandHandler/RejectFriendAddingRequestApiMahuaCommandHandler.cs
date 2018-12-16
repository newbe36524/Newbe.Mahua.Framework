using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 拒绝添加好友请求
    /// </summary>
    public class RejectFriendAddingRequestApiMahuaCommandHandler
		: IApiCommandHandler<RejectFriendAddingRequestApiMahuaCommand>
    {
        public void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

