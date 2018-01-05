namespace Newbe.Mahua.Apis
{
    public class SendDiscussMessageApiMahuaCommand : ApiMahuaCommand
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
}
