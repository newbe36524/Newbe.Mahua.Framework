using System;
using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 设置群成员专属头衔
    /// </summary>
    [Description("设置群成员专属头衔")]
    public class SetGroupMemberSpecialTitleApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public string SpecialTitle { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
