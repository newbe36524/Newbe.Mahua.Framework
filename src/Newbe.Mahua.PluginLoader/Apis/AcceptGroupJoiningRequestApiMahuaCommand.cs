namespace Newbe.Mahua.Apis
{
    public class AcceptGroupJoiningRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningRequestId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }
    }
}
