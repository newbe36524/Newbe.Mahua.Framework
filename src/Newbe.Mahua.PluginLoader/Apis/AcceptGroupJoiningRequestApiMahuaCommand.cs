using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 管理员同意入群申请
    /// </summary>
    [Description("管理员同意入群申请")]
    public class AcceptGroupJoiningRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningRequestId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }
    }
}
