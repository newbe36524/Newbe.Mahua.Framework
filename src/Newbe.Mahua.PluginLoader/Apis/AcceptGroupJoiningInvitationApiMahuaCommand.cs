using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 接受入群邀请
    /// </summary>
    [Description("接受入群邀请")]
    public class AcceptGroupJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningInvitationId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }
    }
}
