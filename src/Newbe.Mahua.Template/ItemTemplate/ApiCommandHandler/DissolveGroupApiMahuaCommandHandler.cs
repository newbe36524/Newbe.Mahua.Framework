using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 解散群
    /// </summary>
    public class DissolveGroupApiMahuaCommandHandler
		: IApiCommandHandler<DissolveGroupApiMahuaCommand>
    {
        public void Handle(DissolveGroupApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

