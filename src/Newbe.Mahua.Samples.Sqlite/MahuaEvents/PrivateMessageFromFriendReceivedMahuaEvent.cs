using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.Sqlite.Services;

namespace Newbe.Mahua.Samples.Sqlite.MahuaEvents
{
    /// <summary>
    /// 来自好友的私聊消息接收事件
    /// </summary>
    public class PrivateMessageFromFriendReceivedMahuaEvent
        : IPrivateMessageFromFriendReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IFriendMessageStore _friendMessageStore;

        public PrivateMessageFromFriendReceivedMahuaEvent(
            IMahuaApi mahuaApi,
            IFriendMessageStore friendMessageStore)
        {
            _mahuaApi = mahuaApi;
            _friendMessageStore = friendMessageStore;
        }

        public void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context)
        {
            _friendMessageStore.InsertAsync(new InsertFriendMessageInput
            {
                Message = context.Message,
                Qq = context.FromQq,
                ReceivedTime = context.SendTime
            }).GetAwaiter().GetResult();
            var count = _friendMessageStore.GetCountAsync().GetAwaiter().GetResult();
            _mahuaApi.SendPrivateMessage(context.FromQq, $"存储中已经存在{count}条好友信息。");
        }
    }
}
