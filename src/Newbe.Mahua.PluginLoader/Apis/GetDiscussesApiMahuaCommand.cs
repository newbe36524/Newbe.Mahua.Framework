using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 获取讨论组列表
    /// </summary>
    [Description("获取讨论组列表")]
    public class GetDiscussesApiMahuaCommand : ApiMahuaCommand<GetDiscussesApiMahuaCommandResult>
    {
    }

    public class GetDiscussesApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string DiscussesString { get; set; }
    }
}
