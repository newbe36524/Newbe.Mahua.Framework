using System;

namespace Newbe.Mahua.Apis
{
    public class SetGroupMemberSpecialTitleApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public string SpecialTitle { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
