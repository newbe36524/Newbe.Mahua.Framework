using System.ComponentModel;

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
        /// 适用於酷Q撒回信息
        /// </summary>
        public long MessageId { get; set; }
    }

}
