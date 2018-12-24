using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 设置禁言某匿名群员
    /// </summary>
    public class BanGroupAnonymousMemberApiMahuaCommandHandler
		: IApiCommandHandler<BanGroupAnonymousMemberApiMahuaCommand>
    {
        public void Handle(BanGroupAnonymousMemberApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

