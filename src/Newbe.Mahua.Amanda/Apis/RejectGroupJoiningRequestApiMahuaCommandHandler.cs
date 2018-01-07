using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class RejectGroupJoiningRequestApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<RejectGroupJoiningRequestApiMahuaCommand>
    {
        public RejectGroupJoiningRequestApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
            AmandaApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningRequestId,
                AmandaConstants.Operation拒绝,
                null);
        }
    }
}
