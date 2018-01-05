namespace Newbe.Mahua.Apis
{
    public class GetLoginNickApiMahuaCommand : ApiMahuaCommand<GetLoginNickApiMahuaCommandResult>
    {
    }

    public class GetLoginNickApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Nick { get; set; }
    }
}
