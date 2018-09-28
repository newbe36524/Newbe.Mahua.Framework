using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 撤回消息
    /// </summary>
    [Description("撤回消息")]
    public class DeleteMessageApiMahuaCommand : ApiMahuaCommand<DeleteMessageApiMahuaCommandResult>
    {
        public long MessageId { get; set; }

        public string TargetId { get; set; }

        public int Type { get; set; }
    }

    public class DeleteMessageApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public bool IsDeleted { get; set; }
    }
}
