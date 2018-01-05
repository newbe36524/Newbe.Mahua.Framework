using System.Collections.Generic;

namespace Newbe.Mahua.Apis
{
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
