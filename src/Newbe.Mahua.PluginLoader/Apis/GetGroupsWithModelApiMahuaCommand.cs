using System.Collections.Generic;

namespace Newbe.Mahua.Apis
{
    public class GetGroupsWithModelApiMahuaCommand : ApiMahuaCommand<GetGroupsWithModelApiMahuaCommandResult>
    {
    }

    public class GetGroupsWithModelApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public ModelWithSourceString<IEnumerable<GroupInfo>> ModelWithSourceString { get; set; }
    }
}
