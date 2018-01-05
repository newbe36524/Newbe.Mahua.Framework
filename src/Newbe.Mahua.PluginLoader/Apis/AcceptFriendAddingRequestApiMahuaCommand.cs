namespace Newbe.Mahua.Apis
{
    public class AcceptFriendAddingRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string AddingFriendRequestId { get; set; }

        public string FromQq { get; set; }

        public string FriendRemark { get; set; }
    }
}
