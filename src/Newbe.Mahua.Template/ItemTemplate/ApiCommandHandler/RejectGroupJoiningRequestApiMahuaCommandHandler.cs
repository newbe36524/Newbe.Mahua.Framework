using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 管理员拒绝入群申请
    /// </summary>
    public class RejectGroupJoiningRequestApiMahuaCommandHandler
		: IApiCommandHandler<RejectGroupJoiningRequestApiMahuaCommand>
    {
        public void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

