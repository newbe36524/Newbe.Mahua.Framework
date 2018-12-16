using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 获取群列表
    /// </summary>
    public class GetGroupsWithModelApiMahuaCommandHandler
		: IApiCommandHandler<GetGroupsWithModelApiMahuaCommand,GetGroupsWithModelApiMahuaCommandResult>
    {
        public GetGroupsWithModelApiMahuaCommandResult Handle(GetGroupsWithModelApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

