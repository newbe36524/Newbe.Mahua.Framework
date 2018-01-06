using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 设置群管理员
    /// </summary>
    [Description("设置群管理员")]
    public class EnableGroupAdminApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }
    }
}
