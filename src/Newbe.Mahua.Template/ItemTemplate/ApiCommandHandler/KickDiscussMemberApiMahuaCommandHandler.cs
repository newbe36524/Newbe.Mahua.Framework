using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 踢出讨论组
    /// </summary>
    public class KickDiscussMemberApiMahuaCommandHandler
		: IApiCommandHandler<KickDiscussMemberApiMahuaCommand>
    {
        public void Handle(KickDiscussMemberApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

