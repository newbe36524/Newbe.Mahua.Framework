using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Plugins.Parrot.Tests
{
    /// <summary>
    /// 只有包含收到回复，才需要回复
    /// </summary>
    public class PrivateMessageFromFriendReceivedMahuaEventV2
        : IPrivateMessageFromFriendReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PrivateMessageFromFriendReceivedMahuaEventV2(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context)
        {
            if (context.Message?.Contains("收到回复") == true)
            {
                var msg = context.Message.Replace("收到回复", string.Empty);
                _mahuaApi.SendPrivateMessage(context.FromQq, msg);
            }
        }
    }
}
