using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 设置群成员专属头衔
    /// </summary>
    public class SetGroupMemberSpecialTitleApiMahuaCommandHandler
		: IApiCommandHandler<SetGroupMemberSpecialTitleApiMahuaCommand>
    {
        public void Handle(SetGroupMemberSpecialTitleApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

