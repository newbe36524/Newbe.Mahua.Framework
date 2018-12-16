using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 发送名片赞
    /// </summary>
    public class SendLikeApiMahuaCommandHandler
		: IApiCommandHandler<SendLikeApiMahuaCommand>
    {
        public void Handle(SendLikeApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

