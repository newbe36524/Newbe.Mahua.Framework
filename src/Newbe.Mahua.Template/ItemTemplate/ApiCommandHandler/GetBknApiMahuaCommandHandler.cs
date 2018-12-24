using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 取bkn
    /// </summary>
    public class GetBknApiMahuaCommandHandler
		: IApiCommandHandler<GetBknApiMahuaCommand,GetBknApiMahuaCommandResult>
    {
        public GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

