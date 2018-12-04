using System.ComponentModel;
using Newbe.Mahua.Messages.CancelMessage;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送私聊消息
    /// </summary>
    [Description("发送私聊消息")]
    public class SendPrivateMessageApiMahuaCommand : ApiMahuaCommand<SendPrivateMessageApiMahuaCommandResult>
    {
        public string ToQq { get; set; }

        public string Message { get; set; }
    }

    public class SendPrivateMessageApiMahuaCommandResult : ApiMahuaCommandResult
    {
        /// <summary>
        /// 用于撤销消息的令牌
        /// </summary>
        public IMessageCancelToken MessageCancelToken { get; set; }
    }
}
