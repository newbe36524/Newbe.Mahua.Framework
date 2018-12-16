using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 取消禁言某群成员
    /// </summary>
    public class RemoveBanGroupMemberApiMahuaCommandHandler
		: IApiCommandHandler<RemoveBanGroupMemberApiMahuaCommand>
    {
        public void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

