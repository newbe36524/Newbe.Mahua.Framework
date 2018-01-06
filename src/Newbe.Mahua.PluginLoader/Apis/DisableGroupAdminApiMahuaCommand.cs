using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 删除群管理员
    /// </summary>
    [Description("删除群管理员")]
    public class DisableGroupAdminApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }
    }
}
