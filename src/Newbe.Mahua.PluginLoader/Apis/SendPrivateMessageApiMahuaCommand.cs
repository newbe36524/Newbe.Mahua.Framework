namespace Newbe.Mahua.Apis
{
    public class SendPrivateMessageApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }

        public string Message { get; set; }
    }
}
