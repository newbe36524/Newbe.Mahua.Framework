using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 发布群公告
    /// </summary>
    [Description("发布群公告")]
    public class SetNoticeApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
