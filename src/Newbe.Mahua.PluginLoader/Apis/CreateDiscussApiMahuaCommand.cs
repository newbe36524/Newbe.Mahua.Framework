namespace Newbe.Mahua.Apis
{
    public class CreateDiscussApiMahuaCommand : ApiMahuaCommand<CreateDiscussApiMahuaCommandResult>
    {
    }

    public class CreateDiscussApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string DiscussId { get; set; }
    }
}
