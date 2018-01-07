using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 取当前登录QQ
    /// </summary>
    [Description("取当前登录QQ")]
    public class GetLoginQqApiMahuaCommand : ApiMahuaCommand<GetLoginQqApiMahuaCommandResult>
    {
    }

    public class GetLoginQqApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Qq { get; set; }
    }
}
