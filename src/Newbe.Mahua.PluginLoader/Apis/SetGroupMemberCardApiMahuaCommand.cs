using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 设置群成员名片
    /// </summary>
    [Description("设置群成员名片")]
    public class SetGroupMemberCardApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public string GroupMemberCard { get; set; }
    }
}
