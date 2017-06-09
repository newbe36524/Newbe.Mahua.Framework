using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群文件上传事件
    /// </summary>
    [Description("群文件上传事件")]
    public interface IGroupUploadedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupUploaded(GroupUploadedContext context);
    }

    public class GroupUploadedContext
    {
        public DateTime SendTime { get; set; }
        public string FromGroup { get; set; }
        public string FromQq { get; set; }
        public string File { get; set; }
    }
}