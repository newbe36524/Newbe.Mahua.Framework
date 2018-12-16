using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 退出讨论组
    /// </summary>
    public class LeaveDiscussApiMahuaCommandHandler
		: IApiCommandHandler<LeaveDiscussApiMahuaCommand>
    {
        public void Handle(LeaveDiscussApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

