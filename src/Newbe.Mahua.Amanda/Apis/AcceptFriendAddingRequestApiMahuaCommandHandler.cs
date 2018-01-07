using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class AcceptFriendAddingRequestApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public AcceptFriendAddingRequestApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(AcceptFriendAddingRequestApiMahuaCommand message)
        {
            AmandaApi.Api_SetFriendAdd(message.FromQq, AmandaConstants.Operation同意, null);
        }
    }
}
