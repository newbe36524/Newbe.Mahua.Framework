using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.LiveGirl.Services;

namespace Newbe.Mahua.Samples.LiveGirl.MahuaEvents
{
    /// <summary>
    /// 来自好友的私聊消息接收事件
    /// </summary>
    public class PrivateMessageFromFriendReceivedMahuaEvent
        : IPrivateMessageFromFriendReceivedMahuaEvent
    {
        private readonly ILivegirl _livegirl;

        public PrivateMessageFromFriendReceivedMahuaEvent(
            ILivegirl livegirl)
        {
            _livegirl = livegirl;
        }

        public void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context)
        {
            if (context.FromQq == "472158246")
            {
                switch (context.Message)
                {
                    case "直播姬起飞":
                        _livegirl.StartAsync().GetAwaiter().GetResult();
                        break;
                    case "直播姬降落":
                        _livegirl.StopAsnyc().GetAwaiter().GetResult();
                        break;
                }
            }
        }
    }
}
