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
            // 获取好友列表
            var friends = _mahuaApi.GetFriends();

            // 测试好友消息发送
            _mahuaApi.SendPrivateMessage(context.FromQq, "这条消息将写入到日志当中");

            // 测试设置公告接口，需要本QQ在目标群具备管理员权限
            _mahuaApi.SetNotice("610394020", "测试公告", friends);
        }
    }
}
