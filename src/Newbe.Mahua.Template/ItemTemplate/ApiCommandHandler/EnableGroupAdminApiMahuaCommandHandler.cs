using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 设置群管理员
    /// </summary>
    public class EnableGroupAdminApiMahuaCommandHandler
		: IApiCommandHandler<EnableGroupAdminApiMahuaCommand>
    {
        public void Handle(EnableGroupAdminApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

