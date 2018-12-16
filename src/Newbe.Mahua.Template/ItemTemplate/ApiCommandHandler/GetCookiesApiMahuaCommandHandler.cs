using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 取Cookies
    /// </summary>
    public class GetCookiesApiMahuaCommandHandler
		: IApiCommandHandler<GetCookiesApiMahuaCommand,GetCookiesApiMahuaCommandResult>
    {
        public GetCookiesApiMahuaCommandResult Handle(GetCookiesApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

