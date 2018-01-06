using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 删除好友
    /// </summary>
    [Description("删除好友")]
    public class RemoveFriendApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }
    }
}
