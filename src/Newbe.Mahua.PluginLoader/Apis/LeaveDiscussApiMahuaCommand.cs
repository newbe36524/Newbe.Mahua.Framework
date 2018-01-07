using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 退出讨论组
    /// </summary>
    [Description("退出讨论组")]
    public class LeaveDiscussApiMahuaCommand : ApiMahuaCommand
    {
        public string ToDiscuss { get; set; }
    }
}
