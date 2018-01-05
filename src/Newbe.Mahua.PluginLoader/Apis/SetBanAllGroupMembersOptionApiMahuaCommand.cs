namespace Newbe.Mahua.Apis
{
    public class SetBanAllGroupMembersOptionApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public bool Enabled { get; set; }
    }
}
