using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 退出群
    /// </summary>
    public class LeaveGroupApiMahuaCommandHandler
		: IApiCommandHandler<LeaveGroupApiMahuaCommand>
    {
        public void Handle(LeaveGroupApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

