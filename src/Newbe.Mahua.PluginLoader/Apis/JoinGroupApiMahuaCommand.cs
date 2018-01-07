using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 主动加群
    /// </summary>
    [Description("主动加群")]
    public class JoinGroupApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string Reason { get; set; }
    }
}
