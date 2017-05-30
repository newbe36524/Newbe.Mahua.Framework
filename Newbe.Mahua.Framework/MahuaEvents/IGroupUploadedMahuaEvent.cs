using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupUploadedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupUploaded(GroupUploadedContext context);
    }

    public class GroupUploadedContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string File { get; set; }
    }
}