using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 创建讨论组
    /// </summary>
    public class CreateDiscussApiMahuaCommandHandler
		: IApiCommandHandler<CreateDiscussApiMahuaCommand,CreateDiscussApiMahuaCommandResult>
    {
        public CreateDiscussApiMahuaCommandResult Handle(CreateDiscussApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

