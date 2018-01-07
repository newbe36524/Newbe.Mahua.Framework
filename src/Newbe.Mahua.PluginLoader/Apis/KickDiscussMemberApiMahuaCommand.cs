using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 踢出讨论组
    /// </summary>
    [Description("踢出讨论组")]
    public class KickDiscussMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToDiscuss { get; set; }

        public string ToQq { get; set; }
    }
}
