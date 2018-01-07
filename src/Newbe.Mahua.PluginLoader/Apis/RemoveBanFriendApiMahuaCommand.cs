using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 将QQ移出黑名单
    /// </summary>
    [Description("将QQ移出黑名单")]
    public class RemoveBanFriendApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }
    }
}
