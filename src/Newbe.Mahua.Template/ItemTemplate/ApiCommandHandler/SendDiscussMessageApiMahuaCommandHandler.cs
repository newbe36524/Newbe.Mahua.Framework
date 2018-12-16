using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 发送讨论组消息
    /// </summary>
    public class SendDiscussMessageApiMahuaCommandHandler
		: IApiCommandHandler<SendDiscussMessageApiMahuaCommand,SendDiscussMessageApiMahuaCommandResult>
    {
        public SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

