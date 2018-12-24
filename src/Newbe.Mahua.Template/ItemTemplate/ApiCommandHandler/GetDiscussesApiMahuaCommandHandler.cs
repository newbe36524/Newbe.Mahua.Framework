using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 获取讨论组列表
    /// </summary>
    public class GetDiscussesApiMahuaCommandHandler
		: IApiCommandHandler<GetDiscussesApiMahuaCommand,GetDiscussesApiMahuaCommandResult>
    {
        public GetDiscussesApiMahuaCommandResult Handle(GetDiscussesApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

