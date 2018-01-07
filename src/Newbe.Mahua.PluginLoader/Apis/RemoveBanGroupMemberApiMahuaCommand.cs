using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 取消禁言某群成员
    /// </summary>
    [Description("取消禁言某群成员")]
    public class RemoveBanGroupMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }
    }
}
