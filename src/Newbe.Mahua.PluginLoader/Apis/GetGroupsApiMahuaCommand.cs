namespace Newbe.Mahua.Apis
{
    public class GetGroupsApiMahuaCommand : ApiMahuaCommand<GetGroupsApiMahuaCommandResult>
    {
    }

    public class GetGroupsApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string GroupsString { get; set; }
    }
}
