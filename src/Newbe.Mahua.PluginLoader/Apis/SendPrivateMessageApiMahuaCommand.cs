using System.ComponentModel;

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
        /// 消息ID
        /// </summary>
        public long MessageId { get; set; }
    }
}
