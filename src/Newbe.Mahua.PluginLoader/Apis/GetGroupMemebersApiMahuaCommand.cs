using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 获取群成员列表（返回字符串）
    /// </summary>
    [Description("获取群成员列表（返回字符串）")]
    public class GetGroupMemebersApiMahuaCommand : ApiMahuaCommand<GetGroupMemebersApiMahuaCommandResult>
    {
        public string ToGroup { get; set; }
    }

    public class GetGroupMemebersApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string GroupMemebersString { get; set; }
    }
}
