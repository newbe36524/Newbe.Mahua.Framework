using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 取当前登录QQ
    /// </summary>
    public class GetLoginQqApiMahuaCommandHandler
		: IApiCommandHandler<GetLoginQqApiMahuaCommand,GetLoginQqApiMahuaCommandResult>
    {
        public GetLoginQqApiMahuaCommandResult Handle(GetLoginQqApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

