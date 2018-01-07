using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetGroupMemebersWithModelApiMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<GetGroupMemebersWithModelApiMahuaCommand, GetGroupMemebersWithModelApiMahuaCommandResult>
    {
        private readonly IGroupMemberInfoSerializer _groupMemberInfoSerializer;

        public GetGroupMemebersWithModelApiMahuaCommandHandler(
            IGroupMemberInfoSerializer groupMemberInfoSerializer,
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
            _groupMemberInfoSerializer = groupMemberInfoSerializer;
        }

        public override GetGroupMemebersWithModelApiMahuaCommandResult Handle(
            GetGroupMemebersWithModelApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_getGroupMemberList(AuthCode, long.Parse(message.ToGroup));
            var modelWithSourceString = new ModelWithSourceString<IEnumerable<GroupMemberInfo>>
            {
                SourceString = source,
                Model = _groupMemberInfoSerializer.DeserializeGroupMemberInfos(source),
            };
            var re = new GetGroupMemebersWithModelApiMahuaCommandResult
            {
                ModelWithSourceString = modelWithSourceString
            };
            return re;
        }
    }
}
