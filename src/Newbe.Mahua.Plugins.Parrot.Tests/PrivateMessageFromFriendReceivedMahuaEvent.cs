using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Plugins.Parrot.Tests
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
            //将好友信息会发给好友
            _mahuaApi.SendPrivateMessage(context.FromQq, context.Message);
        }
    }
}
