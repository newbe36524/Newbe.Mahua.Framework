using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 删除群管理员
    /// </summary>
    public class DisableGroupAdminApiMahuaCommandHandler
		: IApiCommandHandler<DisableGroupAdminApiMahuaCommand>
    {
        public void Handle(DisableGroupAdminApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

