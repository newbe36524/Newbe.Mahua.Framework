namespace Newbe.Mahua.Apis
{
    public class GetDiscussesApiMahuaCommand : ApiMahuaCommand<GetDiscussesApiMahuaCommandResult>
    {
    }

    public class GetDiscussesApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string DiscussesString { get; set; }
    }
}
