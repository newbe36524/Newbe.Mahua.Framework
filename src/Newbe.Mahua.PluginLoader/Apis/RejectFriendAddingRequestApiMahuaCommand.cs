using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 拒绝添加好友请求
    /// </summary>
    [Description("拒绝添加好友请求")]
    public class RejectFriendAddingRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string AddingFriendRequestId { get; set; }

        public string FromQq { get; set; }
    }
}
