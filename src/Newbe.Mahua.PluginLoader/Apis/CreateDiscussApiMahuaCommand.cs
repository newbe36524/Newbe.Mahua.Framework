using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 创建讨论组
    /// </summary>
    [Description("创建讨论组")]
    public class CreateDiscussApiMahuaCommand : ApiMahuaCommand<CreateDiscussApiMahuaCommandResult>
    {
    }

    public class CreateDiscussApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string DiscussId { get; set; }
    }
}
