using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 获取好友列表
    /// </summary>
    [Description("获取好友列表")]
    public class GetFriendsApiMahuaCommand : ApiMahuaCommand<GetFriendsApiMahuaCommandResult>
    {
    }

    public class GetFriendsApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string FriendsString { get; set; }
    }
}
