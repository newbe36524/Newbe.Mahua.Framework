using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 发布群公告
    /// </summary>
    public class SetNoticeApiMahuaCommandHandler
		: IApiCommandHandler<SetNoticeApiMahuaCommand>
    {
        public void Handle(SetNoticeApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

