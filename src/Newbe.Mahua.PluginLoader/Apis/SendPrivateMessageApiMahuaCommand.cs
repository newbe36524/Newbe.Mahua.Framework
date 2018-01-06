using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送私聊消息
    /// </summary>
    [Description("发送私聊消息")]
    public class SendPrivateMessageApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }

        public string Message { get; set; }
    }
}
