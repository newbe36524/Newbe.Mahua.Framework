using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SetGroupAnonymousOptionApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SetGroupAnonymousOptionApiMahuaCommand>
    {
        public SetGroupAnonymousOptionApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SetGroupAnonymousOptionApiMahuaCommand message)
        {
            AmandaApi.Api_SetAnony(message.ToGroup, message.Enabled);
        }
    }
}
