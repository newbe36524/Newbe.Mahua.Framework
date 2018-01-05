namespace Newbe.Mahua.Apis
{
    public class GetFriendsApiMahuaCommand : ApiMahuaCommand<GetFriendsApiMahuaCommandResult>
    {
    }

    public class GetFriendsApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string FriendsString { get; set; }
    }
}
