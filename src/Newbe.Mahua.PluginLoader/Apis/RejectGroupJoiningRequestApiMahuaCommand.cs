namespace Newbe.Mahua.Apis
{
    public class RejectGroupJoiningRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningRequestId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }

        public string Reason { get; set; }
    }
}
