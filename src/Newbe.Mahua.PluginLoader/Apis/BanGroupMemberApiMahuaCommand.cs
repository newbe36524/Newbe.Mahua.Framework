using System;

namespace Newbe.Mahua.Apis
{
    public class BanGroupMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
