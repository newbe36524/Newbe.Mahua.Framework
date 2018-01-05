namespace Newbe.Mahua.Apis
{
    public class KickGroupMemberApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public bool RejectForever { get; set; }
    }
}
