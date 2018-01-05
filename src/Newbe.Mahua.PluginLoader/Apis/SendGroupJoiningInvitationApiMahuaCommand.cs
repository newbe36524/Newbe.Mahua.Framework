namespace Newbe.Mahua.Apis
{
    public class SendGroupJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string ToQq { get; set; }

        public string ToGroup { get; set; }
    }
}
