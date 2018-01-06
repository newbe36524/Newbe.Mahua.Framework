using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class JoinGroupApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<JoinGroupApiMahuaCommand>
    {
        public JoinGroupApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(JoinGroupApiMahuaCommand message)
        {
            AmandaApi.Api_AddGroup(message.ToGroup, message.Reason);
        }
    }
}
