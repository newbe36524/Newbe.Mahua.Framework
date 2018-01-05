namespace Newbe.Mahua.Apis
{
    public class SetNoticeApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
