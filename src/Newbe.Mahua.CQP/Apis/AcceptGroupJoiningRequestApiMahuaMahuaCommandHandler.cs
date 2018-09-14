using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class AcceptGroupJoiningRequestApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        public AcceptGroupJoiningRequestApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupAddRequestV2(
                AuthCode,
                message.GroupJoiningRequestId,
                CoolConstants.RequestType请求群添加,
                CoolConstants.AcceptType请求通过,
                null);
        }
    }
}
