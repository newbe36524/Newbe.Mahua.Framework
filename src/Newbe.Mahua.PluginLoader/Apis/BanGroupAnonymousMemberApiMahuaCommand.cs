using System;
using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 设置禁言某匿名群员
    /// </summary>
    [Description("设置禁言某匿名群员")]
    public class BanGroupAnonymousMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string Anonymous { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
