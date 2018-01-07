using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 退出群
    /// </summary>
    [Description("退出群")]
    public class LeaveGroupApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }
    }
}
