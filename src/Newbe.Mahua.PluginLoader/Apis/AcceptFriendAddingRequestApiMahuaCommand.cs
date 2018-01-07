using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 同意添加好友请求
    /// </summary>
    [Description("同意添加好友请求")]
    public class AcceptFriendAddingRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string AddingFriendRequestId { get; set; }

        public string FromQq { get; set; }

        public string FriendRemark { get; set; }
    }
}
