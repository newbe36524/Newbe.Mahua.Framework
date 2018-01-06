using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 获取群列表（返回字符串）
    /// </summary>
    [Description("获取群列表（返回字符串）")]
    public class GetGroupsApiMahuaCommand : ApiMahuaCommand<GetGroupsApiMahuaCommandResult>
    {
    }

    public class GetGroupsApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string GroupsString { get; set; }
    }
}
