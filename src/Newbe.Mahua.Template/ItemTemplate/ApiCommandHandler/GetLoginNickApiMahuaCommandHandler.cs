using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 取当前登录QQ昵称
    /// </summary>
    public class GetLoginNickApiMahuaCommandHandler
		: IApiCommandHandler<GetLoginNickApiMahuaCommand,GetLoginNickApiMahuaCommandResult>
    {
        public GetLoginNickApiMahuaCommandResult Handle(GetLoginNickApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

