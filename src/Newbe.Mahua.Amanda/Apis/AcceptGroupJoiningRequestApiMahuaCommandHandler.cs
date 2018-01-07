using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class AcceptGroupJoiningRequestApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        public AcceptGroupJoiningRequestApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
            AmandaApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningRequestId,
                AmandaConstants.Operation同意,
                null);
        }
    }
}
