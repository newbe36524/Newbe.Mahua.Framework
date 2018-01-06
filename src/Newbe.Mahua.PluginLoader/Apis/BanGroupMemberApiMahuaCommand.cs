using System;
using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 禁言某群成员
    /// </summary>
    [Description("禁言某群成员")]
    public class BanGroupMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
