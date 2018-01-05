namespace Newbe.Mahua.Apis
{
    public class GetBknApiMahuaCommand : ApiMahuaCommand<GetBknApiMahuaCommandResult>
    {
    }

    public class GetBknApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Bkn { get; set; }
    }
}
