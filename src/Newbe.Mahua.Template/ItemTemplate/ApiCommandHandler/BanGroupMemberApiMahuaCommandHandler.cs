using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 禁言某群成员
    /// </summary>
    public class BanGroupMemberApiMahuaCommandHandler
		: IApiCommandHandler<BanGroupMemberApiMahuaCommand>
    {
        public void Handle(BanGroupMemberApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

