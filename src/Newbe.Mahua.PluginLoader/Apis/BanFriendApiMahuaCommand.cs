using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 将QQ移入黑名单
    /// </summary>
    [Description("将QQ移入黑名单")]
    public class BanFriendApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }
    }
}
