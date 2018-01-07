using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 设置全群禁言
    /// </summary>
    [Description("设置全群禁言")]
    public class SetBanAllGroupMembersOptionApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public bool Enabled { get; set; }
    }
}
