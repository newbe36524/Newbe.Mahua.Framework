using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 管理员同意入群申请
    /// </summary>
    public class AcceptGroupJoiningRequestApiMahuaCommandHandler
		: IApiCommandHandler<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        public void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

