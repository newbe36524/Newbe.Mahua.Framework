using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class RejectGroupJoiningRequestApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<RejectGroupJoiningRequestApiMahuaCommand>
    {
        public RejectGroupJoiningRequestApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAddRequestV2(
                AuthCode,
                message.GroupJoiningRequestId,
                CoolConstants.RequestType请求群添加,
                CoolConstants.AcceptType请求拒绝,
                message.Reason);
        }
    }
}
