namespace Newbe.Mahua.Apis
{
    public class SetGroupAnonymousOptionApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public bool Enabled { get; set; }
    }
}
