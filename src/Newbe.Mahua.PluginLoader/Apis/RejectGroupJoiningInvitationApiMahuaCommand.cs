using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 拒绝入群邀请
    /// </summary>
    [Description("拒绝入群邀请")]
    public class RejectGroupJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningInvitationId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }

        public string Reason { get; set; }
    }
}
