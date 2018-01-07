using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class DissolveGroupApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        public DissolveGroupApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(DissolveGroupApiMahuaCommand message)
        {
            AmandaApi.Api_RemoveGroup(message.ToGroup);
        }
    }
}
