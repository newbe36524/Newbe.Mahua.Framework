using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 取bkn
    /// </summary>
    [Description("取bkn")]
    public class GetBknApiMahuaCommand : ApiMahuaCommand<GetBknApiMahuaCommandResult>
    {
    }

    public class GetBknApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Bkn { get; set; }
    }
}
