using Newbe.Mahua.MahuaEvents;
using System;

namespace $rootnamespace$
{
    /// <summary>
    /// 来自在线状态的私聊消息接收事件
    /// </summary>
    public class PrivateMessageFromOnlineReceivedMahuaEvent
        : IPrivateMessageFromOnlineReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public $safeitemname$(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessOnlineMessage(PrivateMessageFromOnlineReceivedContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}
