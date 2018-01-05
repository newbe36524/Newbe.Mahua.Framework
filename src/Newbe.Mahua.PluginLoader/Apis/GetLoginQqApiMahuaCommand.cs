namespace Newbe.Mahua.Apis
{
    public class GetLoginQqApiMahuaCommand : ApiMahuaCommand<GetLoginQqApiMahuaCommandResult>
    {
    }

    public class GetLoginQqApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Qq { get; set; }
    }
}
