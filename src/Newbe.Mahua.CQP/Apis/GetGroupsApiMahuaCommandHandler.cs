using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetGroupsApiMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>
    {
        public GetGroupsApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override GetGroupsApiMahuaCommandResult Handle(
            GetGroupsApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_getGroupList(AuthCode);
            var re = new GetGroupsApiMahuaCommandResult
            {
                GroupsString = source
            };
            return re;
        }
    }
}
