using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetGroupsWithModelApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<GetGroupsWithModelApiMahuaCommand, GetGroupsWithModelApiMahuaCommandResult>
    {
        private readonly IGroupInfoSerializer _groupInfoSerializer;

        public GetGroupsWithModelApiMahuaCommandHandler(
            IGroupInfoSerializer groupInfoSerializer,
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
            _groupInfoSerializer = groupInfoSerializer;
        }

        public override GetGroupsWithModelApiMahuaCommandResult Handle(
            GetGroupsWithModelApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_getGroupList(AuthCode);
            var modelWithSourceString = new ModelWithSourceString<IEnumerable<GroupInfo>>
            {
                SourceString = source,
                Model = _groupInfoSerializer.DeserializeGroupInfos(source),
            };
            var re = new GetGroupsWithModelApiMahuaCommandResult
            {
                ModelWithSourceString = modelWithSourceString
            };
            return re;
        }
    }
}
