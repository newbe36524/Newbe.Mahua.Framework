using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 接受入群邀请
    /// </summary>
    public class AcceptGroupJoiningInvitationApiMahuaCommandHandler
		: IApiCommandHandler<AcceptGroupJoiningInvitationApiMahuaCommand>
    {
        public void Handle(AcceptGroupJoiningInvitationApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

