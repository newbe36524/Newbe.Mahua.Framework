namespace Newbe.Mahua.Apis
{
    public class GetGroupMemebersApiMahuaCommand : ApiMahuaCommand<GetGroupMemebersApiMahuaCommandResult>
    {
        public string ToGroup { get; set; }
    }

    public class GetGroupMemebersApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string GroupMemebersString { get; set; }
    }
}
