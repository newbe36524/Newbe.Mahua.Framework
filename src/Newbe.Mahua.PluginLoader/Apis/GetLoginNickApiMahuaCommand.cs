using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 取当前登录QQ昵称
    /// </summary>
    [Description("取当前登录QQ昵称")]
    public class GetLoginNickApiMahuaCommand : ApiMahuaCommand<GetLoginNickApiMahuaCommandResult>
    {
    }

    public class GetLoginNickApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Nick { get; set; }
    }
}
