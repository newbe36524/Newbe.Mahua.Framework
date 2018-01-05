using System;

namespace Newbe.Mahua.Apis
{
    public class BanGroupAnonymousMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string Anonymous { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
