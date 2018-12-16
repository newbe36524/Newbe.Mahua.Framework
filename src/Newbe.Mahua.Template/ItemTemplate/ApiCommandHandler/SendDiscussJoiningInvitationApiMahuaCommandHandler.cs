using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 发送讨论组邀请
    /// </summary>
    public class SendDiscussJoiningInvitationApiMahuaCommandHandler
		: IApiCommandHandler<SendDiscussJoiningInvitationApiMahuaCommand>
    {
        public void Handle(SendDiscussJoiningInvitationApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

