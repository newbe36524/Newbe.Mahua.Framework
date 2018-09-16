using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetGroupMemebersApiMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>
    {
        public GetGroupMemebersApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override GetGroupMemebersApiMahuaCommandResult Handle(
            GetGroupMemebersApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_getGroupMemberList(AuthCode, long.Parse(message.ToGroup));
            var re = new GetGroupMemebersApiMahuaCommandResult
            {
                GroupMemebersString = source
            };
            return re;
        }
    }
}
