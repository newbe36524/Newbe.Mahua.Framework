using System.ComponentModel;
using Newbe.Mahua.Messages.CancelMessage;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送讨论组消息
    /// </summary>
    [Description("发送讨论组消息")]
    public class SendDiscussMessageApiMahuaCommand : ApiMahuaCommand<SendDiscussMessageApiMahuaCommandResult>
    {
        /// <summary>
        /// 讨论组
        /// </summary>
        public string ToDiscuss { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }
    }

    public class SendDiscussMessageApiMahuaCommandResult : ApiMahuaCommandResult
    {
        /// <summary>
        /// 用于撤销消息的令牌
        /// </summary>
        public IMessageCancelToken MessageCancelToken { get; set; }
    }

}
