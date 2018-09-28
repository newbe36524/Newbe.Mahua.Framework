using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送群消息
    /// </summary>
    [Description("发送群消息")]
    public class SendGroupMessageApiMahuaCommand : ApiMahuaCommand<SendGroupMessageApiMahuaCommandResult>
    {
        /// <summary>
        /// 目标群
        /// </summary>
        public string ToGroup { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }
    }

    public class SendGroupMessageApiMahuaCommandResult : ApiMahuaCommandResult
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        public long MessageId { get; set; }
    }

}
