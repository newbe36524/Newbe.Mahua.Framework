using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 设置群成员名片
    /// </summary>
    public class SetGroupMemberCardApiMahuaCommandHandler
		: IApiCommandHandler<SetGroupMemberCardApiMahuaCommand>
    {
        public void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

