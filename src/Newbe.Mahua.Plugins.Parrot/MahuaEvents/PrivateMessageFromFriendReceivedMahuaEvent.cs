using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Plugins.Parrot.MahuaEvents
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
            // 戳一戳
            _mahuaApi.SendPrivateMessage(context.FromQq)
                .Shake()
                .Done();
            // 嘤嘤嘤
            _mahuaApi.SendPrivateMessage(context.FromQq)
                .Text("嘤嘤嘤：")
                .Newline()
                .Text(context.Message)
                .Done();

            // 将好友信息会发给好友
            _mahuaApi.SendPrivateMessage(context.FromQq, context.Message);

            _mahuaApi.SendPrivateMessage(context.FromQq)
                .Image(@"D:\logo.png")
                .Done();
        }
    }
}
