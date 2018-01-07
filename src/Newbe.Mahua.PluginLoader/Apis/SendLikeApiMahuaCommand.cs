using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发送名片赞
    /// </summary>
    [Description("发送名片赞")]
    public class SendLikeApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }
    }
}
