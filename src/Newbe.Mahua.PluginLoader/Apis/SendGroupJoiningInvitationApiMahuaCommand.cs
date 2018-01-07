using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送入群邀请
    /// </summary>
    [Description("发送入群邀请")]
    public class SendGroupJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }

        public string ToGroup { get; set; }
    }
}
