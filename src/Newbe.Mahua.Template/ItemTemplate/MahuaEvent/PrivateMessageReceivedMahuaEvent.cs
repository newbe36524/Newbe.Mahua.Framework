using Newbe.Mahua.MahuaEvents;
using System;

namespace $rootnamespace$
{
    /// <summary>
    /// 私聊消息接收事件
    /// </summary>
    public class PrivateMessageReceivedMahuaEvent
        : IPrivateMessageReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public $safeitemname$(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessPrivateMessage(PrivateMessageReceivedContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}
