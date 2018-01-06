using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送讨论组邀请
    /// </summary>
    [Description("发送讨论组邀请")]
    public class SendDiscussJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }

        public string ToDiscuss { get; set; }
    }
}
