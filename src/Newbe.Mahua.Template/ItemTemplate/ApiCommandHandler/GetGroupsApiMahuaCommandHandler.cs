using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 获取群列表（返回字符串）
    /// </summary>
    public class GetGroupsApiMahuaCommandHandler
		: IApiCommandHandler<GetGroupsApiMahuaCommand,GetGroupsApiMahuaCommandResult>
    {
        public GetGroupsApiMahuaCommandResult Handle(GetGroupsApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

