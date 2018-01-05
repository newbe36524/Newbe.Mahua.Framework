namespace Newbe.Mahua.Apis
{
    public class RejectGroupJoiningInvitationApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningInvitationId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }

        public string Reason { get; set; }
    }
}
