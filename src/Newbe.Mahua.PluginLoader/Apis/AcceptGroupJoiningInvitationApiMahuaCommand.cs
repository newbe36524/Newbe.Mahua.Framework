namespace Newbe.Mahua.Apis
{
    public class AcceptGroupJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningInvitationId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }
    }
}
