using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 解散群
    /// </summary>
    [Description("解散群")]
    public class DissolveGroupApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }
    }
}
