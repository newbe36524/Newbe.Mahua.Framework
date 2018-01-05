namespace Newbe.Mahua.Apis
{
    public class SetGroupMemberCardApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public string ToQq { get; set; }

        public string GroupMemberCard { get; set; }
    }
}
