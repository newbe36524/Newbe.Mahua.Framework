using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    /// <summary>
    /// 获取群成员列表
    /// </summary>
    public class GetGroupMemebersWithModelApiMahuaCommandHandler
		: IApiCommandHandler<GetGroupMemebersWithModelApiMahuaCommand,GetGroupMemebersWithModelApiMahuaCommandResult>
    {
        public GetGroupMemebersWithModelApiMahuaCommandResult Handle(GetGroupMemebersWithModelApiMahuaCommand message)
        {
			// todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}

