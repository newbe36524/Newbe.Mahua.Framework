using Newbe.Mahua.MahuaEvents;
using System;

namespace $rootnamespace$
{
    /// <summary>
    /// 来自讨论组成员的私聊消息接收事件
    /// </summary>
    public class PrivateMessageFromDiscussReceivedMahuaEvent
        : IPrivateMessageFromDiscussReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public $safeitemname$(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessDiscussGroupMessage(PrivateMessageFromDiscussReceivedContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}
