using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 移出群成员
    /// </summary>
    [Description("移出群成员")]
    public class KickGroupMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public bool RejectForever { get; set; }
    }
}
