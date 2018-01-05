namespace Newbe.Mahua.Apis
{
    public class GetCookiesApiMahuaCommand : ApiMahuaCommand<GetCookiesApiMahuaCommandResult>
    {
    }

    public class GetCookiesApiMahuaCommandResult : ApiMahuaCommandResult
    {
        public string Cookies { get; set; }
    }
}
