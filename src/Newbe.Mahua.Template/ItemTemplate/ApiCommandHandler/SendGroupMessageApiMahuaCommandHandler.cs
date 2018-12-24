using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 发送群消息
    /// </summary>
    public class SendGroupMessageApiMahuaCommandHandler
		: IApiCommandHandler<SendGroupMessageApiMahuaCommand,SendGroupMessageApiMahuaCommandResult>
    {
        public SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

