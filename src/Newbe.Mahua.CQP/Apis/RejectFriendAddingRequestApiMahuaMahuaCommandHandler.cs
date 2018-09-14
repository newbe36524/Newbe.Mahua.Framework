using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class RejectFriendAddingRequestApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<RejectFriendAddingRequestApiMahuaCommand>
    {
        public RejectFriendAddingRequestApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
            CoolQApi.CQ_setFriendAddRequest(
                AuthCode,
                message.AddingFriendRequestId,
                CoolConstants.AcceptType请求拒绝,
                null);
        }
    }
}
