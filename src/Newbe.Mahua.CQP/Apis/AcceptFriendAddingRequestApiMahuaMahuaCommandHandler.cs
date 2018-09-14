using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class AcceptFriendAddingRequestApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public AcceptFriendAddingRequestApiMahuaMahuaCommandHandler(
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
