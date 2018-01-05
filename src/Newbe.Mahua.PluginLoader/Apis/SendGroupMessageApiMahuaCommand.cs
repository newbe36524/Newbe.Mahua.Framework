namespace Newbe.Mahua.Apis
{
    public class SendGroupMessageApiMahuaCommand : ApiMahuaCommand
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
}
