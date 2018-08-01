using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Samples.HotUpdate.MahuaEvents
{
    /// <summary>
    /// 来自好友的私聊消息接收事件
    /// </summary>
    public class PrivateMessageMahuaEventV2
        : IPrivateMessageReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PrivateMessageMahuaEventV2(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }
        public void ProcessPrivateMessage(PrivateMessageReceivedContext context)
        {
            _mahuaApi.SendPrivateMessage(context.FromQq)
                .Text("嘤嘤嘤 v2")
                .Done();
        }
    }
}
