
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaEvents
{
    /// <summary>
    /// 来自好友的私聊消息接收事件
    /// </summary>
    public class PrivateMessageFromFriendReceivedMahuaEvent
        : IPrivateMessageFromFriendReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PrivateMessageFromFriendReceivedMahuaEvent(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context)
        {
            var friends = _mahuaApi.GetFriends();
            _mahuaApi.SetNotice("text", "标题", friends);
            _mahuaApi.SendPrivateMessage("472158246", "这条消息将写入到日志当中");
        }
    }
}
