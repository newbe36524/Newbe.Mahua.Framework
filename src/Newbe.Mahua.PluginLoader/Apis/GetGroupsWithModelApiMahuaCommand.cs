using System.Collections.Generic;
using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 获取群列表
    /// </summary>
    [Description("获取群列表")]
    public class GetGroupsWithModelApiMahuaCommand : ApiMahuaCommand<GetGroupsWithModelApiMahuaCommandResult>
    {
    }

    public class GetGroupsWithModelApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public ModelWithSourceString<IEnumerable<GroupInfo>> ModelWithSourceString { get; set; }
    }
}
