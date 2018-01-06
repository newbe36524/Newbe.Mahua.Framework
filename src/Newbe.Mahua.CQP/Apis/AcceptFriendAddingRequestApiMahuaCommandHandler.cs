using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class AcceptFriendAddingRequestApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public AcceptFriendAddingRequestApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(AcceptFriendAddingRequestApiMahuaCommand message)
        {
            CoolQApi.CQ_setFriendAddRequest(
                AuthCode,
                message.AddingFriendRequestId,
                CoolConstants.AcceptType请求通过,
                message.FriendRemark);
        }
    }
}
