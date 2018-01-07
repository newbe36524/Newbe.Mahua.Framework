using System.Collections.Generic;
using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 获取群成员列表
    /// </summary>
    [Description("获取群成员列表")]
    public class
        GetGroupMemebersWithModelApiMahuaCommand : ApiMahuaCommand<GetGroupMemebersWithModelApiMahuaCommandResult>
    {
        public string ToGroup { get; set; }
    }

    public class GetGroupMemebersWithModelApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public ModelWithSourceString<IEnumerable<GroupMemberInfo>> ModelWithSourceString { get; set; }
    }
}
