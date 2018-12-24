using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 发送入群邀请
    /// </summary>
    public class SendGroupJoiningInvitationApiMahuaCommandHandler
		: IApiCommandHandler<SendGroupJoiningInvitationApiMahuaCommand>
    {
        public void Handle(SendGroupJoiningInvitationApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

