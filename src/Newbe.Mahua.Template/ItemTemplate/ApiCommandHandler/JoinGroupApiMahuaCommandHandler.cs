using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 主动加群
    /// </summary>
    public class JoinGroupApiMahuaCommandHandler
		: IApiCommandHandler<JoinGroupApiMahuaCommand>
    {
        public void Handle(JoinGroupApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

