using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class RejectFriendAddingRequestApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<RejectFriendAddingRequestApiMahuaCommand>
    {
        public RejectFriendAddingRequestApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
            AmandaApi.Api_SetFriendAdd(message.FromQq, AmandaConstants.Operation拒绝, null);
        }
    }
}
