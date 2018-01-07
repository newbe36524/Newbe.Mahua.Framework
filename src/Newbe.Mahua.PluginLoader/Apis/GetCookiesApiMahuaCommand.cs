using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 取Cookies
    /// </summary>
    [Description("取Cookies")]
    public class GetCookiesApiMahuaCommand : ApiMahuaCommand<GetCookiesApiMahuaCommandResult>
    {
    }

    public class GetCookiesApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Cookies { get; set; }
    }
}
