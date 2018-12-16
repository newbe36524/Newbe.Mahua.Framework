using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 拒绝入群邀请
    /// </summary>
    public class RejectGroupJoiningInvitationApiMahuaCommandHandler
		: IApiCommandHandler<RejectGroupJoiningInvitationApiMahuaCommand>
    {
        public void Handle(RejectGroupJoiningInvitationApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

