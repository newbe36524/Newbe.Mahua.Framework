using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IJoinGroupRequestMahuaEvent : IMahuaEvent
    {
        void ProcessJoinGroupRequest(JoinGroupRequestContext context);
    }

    public class JoinGroupRequestContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}