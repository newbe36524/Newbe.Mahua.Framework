using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class RemoveFriendApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<RemoveFriendApiMahuaCommand>
    {
        public RemoveFriendApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(RemoveFriendApiMahuaCommand message)
        {
            AmandaApi.Api_DeleteFriend(message.ToQq);
        }
    }
}
