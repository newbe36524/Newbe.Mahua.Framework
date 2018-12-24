using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 同意添加好友请求
    /// </summary>
    public class AcceptFriendAddingRequestApiMahuaCommandHandler
		: IApiCommandHandler<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public void Handle(AcceptFriendAddingRequestApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

