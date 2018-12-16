using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 移出群成员
    /// </summary>
    public class KickGroupMemberApiMahuaCommandHandler
		: IApiCommandHandler<KickGroupMemberApiMahuaCommand>
    {
        public void Handle(KickGroupMemberApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

